import 'package:bytebank/Model/transferencia.dart';
import 'package:bytebank/Widgets/formularioTransferencia.dart';
import 'package:flutter/material.dart';
import 'package:flutter/widgets.dart';

class ListaTransferencia extends StatefulWidget {
  final List<Transferencia> _transferencias = List();

  @override
  _ListaTransferenciaState createState() => _ListaTransferenciaState();
}

class _ListaTransferenciaState extends State<ListaTransferencia> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: Text('Transferências do Douglas!')),
      body: ListView.builder(
        itemCount: widget._transferencias.length,
        itemBuilder: (context, indice){
         final Transferencia transferencia = widget._transferencias[indice];
          return ItemTransferencia(transferencia);

        },
      ),
      floatingActionButton: FloatingActionButton(
        child: Icon(Icons.add),
        onPressed: () {
          final Future<Transferencia> future =  Navigator.push(context, MaterialPageRoute(builder: (context){
            return FormularioTransferencia();
          }));
          future.then((transferenciaRecebida){
            if (transferenciaRecebida != null) {
              setState(() {
                widget._transferencias.add(transferenciaRecebida);
              });
            }
          });
        },
      ),
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
