import 'package:bytebank/Controller/TransferenciaController.dart';
import 'package:flutter/material.dart';
import 'package:flutter/widgets.dart';

class FormularioTransferencia extends StatelessWidget {
  final TextEditingController _controladorNumeroConta = TextEditingController();
  final TextEditingController _controladorValor = TextEditingController();

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Nova Transferência'),
      ),
      body: Padding(
        padding: const EdgeInsets.all(20.0),
        child: Column(
          children: <Widget>[
            TextField(
              controller: _controladorNumeroConta,
              decoration: InputDecoration(
                labelText: 'Número da conta',
                hintText: '0000',
                icon: Icon(Icons.account_balance)
              ),
              keyboardType: TextInputType.number,
            ),
            TextField(
              controller: _controladorValor,
              decoration: InputDecoration(
                labelText: 'Valor',
                hintText: '00,00',
                icon: Icon(Icons.monetization_on),
              ),
              keyboardType: TextInputType.number,
            ),
            RaisedButton(
              child: Text('Confirmar'),
              color: Colors.blueAccent,
              onPressed: () {
                final int conta = int.tryParse(_controladorValor.text);
                final double valor = double.tryParse(_controladorValor.text);
                if (conta != null && valor != null) {
                  AddTransferencia(conta, valor);
                }
              },
            ),
          ],
        ),
      ),
    );
  }
}
