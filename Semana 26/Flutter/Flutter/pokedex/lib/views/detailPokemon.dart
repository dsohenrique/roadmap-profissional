import 'package:flutter/material.dart';
import 'package:pokedex/views/pokemon.dart';

class DetailPokemon {
  showPokemonDetail(BuildContext context, Pokemon pokemon) {
    // configura o  AlertDialog
    Dismissible pokemonDetail = Dismissible(
      child: AlertDialog(
      content: Center(
        child: Align(
          child: Hero(
            tag: pokemon.img,
            child: Container(
              decoration: BoxDecoration(
                image: DecorationImage(
                  image: NetworkImage(pokemon.img),
                ),
              ),
            ),
          ),
        ),
      ),
    ),
      key: ValueKey(pokemon),
      direction: DismissDirection.vertical,
      onDismissed: (direction){
        Navigator.pop(context);
      },
    );

    // exibe o dialog
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return pokemonDetail;
      },
    );
  }
}
