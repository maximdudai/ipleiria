'use strict'

const API_KEY = 'ae5200e0';

const movieCard = $('.card-movie').clone();

const searchMovie = () => {
  const inputSearch = $('#input-search').val();
  $('.search-title').text(`Pesquisa: ${inputSearch}`);

  $('.lista-filmes').empty();

  $.ajax({
    url: "http://www.omdbapi.com/?i=tt3896198&apikey=ae5200e0&s=" + inputSearch + '&r=json',
    method: 'get'

  }).done(function (data) {

    console.log(data.Search);

    $.each(data.Search, function (value) {
      var card = movieCard.clone();
      card.find('.card-title').text(value.Title);
      card.find('.card-text').text(value.Type);
      card.find('.card-img-top').attr('src', value.Poster);


      $('.lista-filmes').append(card);

    })

  });

}

$('#btn-search').on('click', () => searchMovie());