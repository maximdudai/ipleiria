const listaFeriados = $('.listaFeriados');
const countryTable = $('.tabelaFeriado');
let totalFeriados = 0;

const getMonth = (monthNumber) => {

  // lista de meses
  const monthNames = ["Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho",
    "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"
  ];
  return monthNames[monthNumber - 1];
}

const criarLista = (value = 0, pais = 'PT', ano = 2024, type = 'normal') => {
  const card = countryTable?.clone();

  $(card).attr('id', totalFeriados);
  $(card).find(".fa-star").attr('id', totalFeriados);

  $(card).find(".dataFeriado").text(value.date);


  //select month from full date
  const getMonthFromDate = value.date.split('-')[1];
  $(card).find(".mesFeriado").text(getMonth(getMonthFromDate));

  $(card).find(".nomeFeriado").text(value.localName);
  $(card).find(".nomeInternacional").text(value.name);

  const currentPage = $(location).attr('pathname'); 
  if(currentPage === '/favorites.html') {
    $(card).find(".toggleFavorites").removeClass('adicionarFavorito');
    $(card).find(".toFavorites .toggleFavorites").addClass('removerFavorito');

  } else {
    $(card).find(".toFavorites .toggleFavorites").addClass('adicionarFavorito');
    $(card).find(".toFavorites .toggleFavorites").removeClass('removerFavorito');
  }


  $(card).find('.adicionarFavorito').attr('id', totalFeriados);

  // verificar se o pais ja existe na lista dos favoritos
  $(card).find('.fa-star').addClass(isCountryListed(value.name) ? 'fa-solid' : 'fa-regular');

  if (pais !== 'PT' && type !== 'favoritos') {
    $(card).find(".adicionarFavorito").remove()
  }
  listaFeriados.append(card);
}

const obterFeriados = (pais = 'PT', ano = 2024) => {
  const getYear = localStorage.getItem('year');

  $.ajax({
    url: `https://date.nager.at/api/v3/publicholidays/${ano}/${pais}`,
    method: 'get'

  }).done(function (data) {
    listaFeriados.empty();

    totalFeriados = 0;

    $.each(data, function (_, value) {

      totalFeriados++;

      criarLista(value, 'PT', 2024, 'normal');
    });

  }).fail(function (err) {
    console.log(err);
  });
}

const obterFavoritos = () => {
  const favoritos = JSON.parse(localStorage.getItem('favoritos')) || [];

  listaFeriados.empty();

  const pais = localStorage.getItem('country');
  const ano = localStorage.getItem('year');

  $.each(favoritos, function (_, value) {

    totalFeriados++;

    criarLista(value, pais, ano, 'favoritos');
  });

}

$(document).ready(() => {

  // obter feriados de Portugal (default) para o ano de 2024 (default)

  // obter a pagina atual
  // se a pagina atual === index.html chamar a API
  // se a pagina atual !== index.html chamar a lista de favoritos

  const currentPage = $(location).attr('pathname'); 
  if(currentPage === '/index.html') {
    obterFeriados();
  }
  else
    obterFavoritos();


  $('.btnFilterCountry').click((e) => {
    // obter ano
    const getYear = localStorage.getItem('year');
    // obter ano
    const pais = e.target.id;

    // guardar filtro
    saveFilterData(pais, getYear ?? 2024);

    // obter feriados
    obterFeriados(pais, getYear);
  });

  $('.btnFilterYear').click((e) => {
    // obter pais
    const getCountry = localStorage.getItem('country');
    // obter ano
    const year = e.target.id;

    // guardar filtro
    saveFilterData(getCountry ?? 'PT', year);

    // obter feriados
    obterFeriados(getCountry, year);
  });

});


$(document).on('click', '.adicionarFavorito', function () {

  const id = $(this).attr('id');
  const card = $(`#${id}`);

  const nomeFeriado = $(card).find('.nomeFeriado').text();

  const dataFeriado = $(card).find('.dataFeriado').text();
  const mesFeriado = $(card).find('.mesFeriado').text();
  const nomeInternacional = $(card).find('.nomeInternacional').text();
  const idFeriado = $(card).attr('id');

  console.log(idFeriado);

  const feriado = {
    id: idFeriado,
    date: dataFeriado,
    month: mesFeriado,
    localName: nomeFeriado,
    name: nomeInternacional
  }


  if(isCountryListed(feriado.name)) {
    
    $(document).find('.fa-star').each(function() {
      if($(this).attr("id") === idFeriado) {
        $(this).removeClass('fa-solid');
        $(this).addClass('fa-regular');
      }
    });

    removeFavoritos(feriado);
    
  } else {

    addFavoritos(feriado);

    $(document).find('.fa-star').each(function() {
      if($(this).attr("id") === idFeriado) {
        $(this).removeClass('fa-regular');
        $(this).addClass('fa-solid');
      }
    });
  }


});

$(document).on('click', '.removerFavorito', function () {

  const id = $(this).attr('id');
  const card = $(`#${id}`);

  const dataFeriado = $(card).find('.dataFeriado').text();
  const mesFeriado = $(card).find('.mesFeriado').text();
  const nomeFeriado = $(card).find('.nomeFeriado').text();
  const nomeInternacional = $(card).find('.nomeInternacional').text();

  const feriado = {
    date: dataFeriado,
    month: mesFeriado,
    localName: nomeFeriado,
    name: nomeInternacional
  }

  removeFavoritos(feriado);

});

function saveFilterData(pais = 'PT', ano = 2024) {
  localStorage.setItem('year', ano);
  localStorage.setItem('country', pais);
}

//verificar se ja existe na lista de favoritos
function isCountryListed(country) {
  const favoritos = JSON.parse(localStorage.getItem('favoritos')) || [];
  return favoritos.some((id) => id.name === country);
}

// adicionar aos favoritos
function addFavoritos(country) {
  const favoritos = JSON.parse(localStorage.getItem('favoritos')) || [];

  const isListed = isCountryListed(country);

  if (!isListed) {
    favoritos.push(country);
    localStorage.setItem('favoritos', JSON.stringify(favoritos));
  }
}

// remover aos favoritos
function removeFavoritos(country) {
  const favoritos = JSON.parse(localStorage.getItem('favoritos')) || [];

  const index = favoritos.findIndex((id) => id.name === country.name);
  favoritos.splice(index, 1);

  localStorage.setItem('favoritos', JSON.stringify(favoritos));

  //atualizar lista
  const currentPage = $(location).attr('pathname'); 
  if(currentPage !== '/index.html') 
    atualizarLista();
}

function atualizarLista() {
  listaFeriados.empty();

  const countries = JSON.parse(localStorage.getItem('favoritos')) || [];

  $.each(countries, function (_, value) {
    criarLista(value, undefined, undefined, 'favoritos');
  });
}