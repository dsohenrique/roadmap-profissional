import 'package:flutter/material.dart';

class Editor extends StatelessWidget {
  final controlador;
  final String rotulo;
  final String dica;
  final IconData icone;

  const Editor({this.controlador, this.rotulo, this.dica, this.icone});

  @override
  Widget build(BuildContext context) {
    return TextField(
      controller: controlador,
      decoration: InputDecoration(
          labelText: rotulo,
          hintText: dica,
          icon: icone != null ? Icon(icone) : null,
      ),
      keyboardType: TextInputType.number,
    );
  }
}
