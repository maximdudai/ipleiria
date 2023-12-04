
const movieCard = $('.card-movie').clone();
const API_KEY = 'ae5200e0';


const searchMovie = () => {
  const inputSearch = $('#input-search').val();
  $('.search-title').text(`Pesquisa: ${inputSearch}`);

  $('.lista-filmes').empty();


  $.ajax({
    url: "http://www.omdbapi.com/?i=tt3896198&apikey=" + API_KEY + "&s=" + inputSearch + '&r=json',
    method: 'get'

  }).done(function (data) {

    $.each(data?.Search, function (_, value) {

      const card = movieCard?.clone();

      $(card).find('.card-title').text(value.Title);
      $(card).find('.card-text').text(value.Type);
      $(card).find('.card-img-top').attr('src', value.Poster);

      $(card).find('.card-link').attr('href', `https://api.themoviedb.org/3/movie/${value.imdbID}`);
      $(card).find('.card-link').attr('target', '_blank');

      const addToFav = $(card).find('#addToFavorite');
      addToFav.text('Adicionar Favoritos');
      
      updateFavorites(addToFav, value);
      updateVisual(addToFav, value);

      $('.lista-filmes').append(card);
    });

  }).fail(function (err) {
    console.log(err);
  });
}

$(document).ready(() => {
  $('#btn-search').on('click', () => searchMovie());
});

const isMovieListed = (movieID) => {
  const favoritos = JSON.parse(localStorage.getItem('favoritos')) || [];
  return favoritos.some((id) => id.imdbID === movieID);
}

function updateFavorites(btn, movie) {

  if (!btn.hasClass('adicionado')) {
    btn.on('click', (e) => {
      e.preventDefault();

      if (isMovieListed(movie.imdbID))
        removeFavoritos(movie);
      else
        addFavoritos(movie);
      
      updateVisual(btn, movie);
    })
  }

}

function updateVisual(btn, movie) {
  const favorite = isMovieListed(movie.imdbID);

  if (favorite) {
    btn.text('Remover Favoritos');
    btn.removeClass('btn-primary');
    btn.addClass('btn-danger');
  } else {
    btn.text('Adicionar Favoritos');
    btn.removeClass('btn-danger');
    btn.addClass('btn-primary');
  
  }
}

function addFavoritos(movie) {
  const favoritos = JSON.parse(localStorage.getItem('favoritos')) || [];

  if(isMovieListed(movie.imdbID)) {
    alert('Filme já adicionado aos favoritos');
  }
  else {
    favoritos.push(movie);
    localStorage.setItem('favoritos', JSON.stringify(favoritos));
  }
}

function removeFavoritos(movie) {
  const favoritos = JSON.parse(localStorage.getItem('favoritos')) || [];

  if(isMovieListed(movie.imdbID)) {
    const index = favoritos.findIndex((id) => id.imdbID === movie.imdbID);
    favoritos.splice(index, 1);

    localStorage.setItem('favoritos', JSON.stringify(favoritos));
  }
  else {
    alert('Filme não está na lista de favoritos');
  }
}