import 'package:flutter/material.dart';
import 'package:flutter/widgets.dart';

import '../Transferencia.dart';

class ListaTransferencia extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Transferencias')
      ),
      body: Column(
        children: <Widget>[
          ItemTransferencia(Transferencia(151.46546, 12331321)),
          ItemTransferencia(Transferencia(4564.6, 4645646546)),
        ],
      ),
      floatingActionButton: Icon(Icons.account_balance_wallet),
    );
  }
}

class ItemTransferencia extends StatelessWidget {
  final Transferencia _transferencia;

  ItemTransferencia(this._transferencia);

  @override
  Widget build(BuildContext context) {
    return Card(
      child: ListTile(
        leading: Icon(Icons.monetization_on),
        title: Text(_transferencia.valor.toString()),
        subtitle: Text(_transferencia.numeroConta.toString()),
      ),
    );
  }
}