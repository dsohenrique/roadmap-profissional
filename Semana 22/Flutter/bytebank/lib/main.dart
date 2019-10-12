import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

void main() => runApp(
      MaterialApp(
        home: Scaffold(
          appBar: AppBar(
            title: Text('Transferencias'),
          ),
          body: ListaTransferencia(),
          floatingActionButton: FloatingActionButton(
            child: Icon(Icons.add_shopping_cart),
          ),
        ),
      ),
    );

class ListaTransferencia extends StatelessWidget{
  @override
  Widget build(BuildContext context) {
    return Column(
      children: <Widget>[
        ItemTransferencia(Transferencia(151.46546, 12331321)),
        ItemTransferencia(Transferencia(4564.6, 4645646546)),
      ],
    );
  }
}

class ItemTransferencia extends StatelessWidget{
  final Transferencia _transferencia;


  ItemTransferencia(this._transferencia);

  @override
  Widget build(BuildContext context) {
    return Card(
      child:  ListTile(
        leading: Icon(Icons.monetization_on),
        title: Text(_transferencia.valor.toString()),
        subtitle: Text(_transferencia.numeroConta.toString()),
      ),
    );
  }
}

class Transferencia{
  final double valor;
  final int numeroConta;

  Transferencia(this.valor, this.numeroConta);

}