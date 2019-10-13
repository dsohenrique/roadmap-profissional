import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

import 'Widgets/listaTransferencia.dart';

void main() => runApp(ByteBank());

class ByteBank extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      home: Scaffold(
        body: ListaTransferencia(),
      ),
    );
  }
}





