import 'package:bytebank/Model/transferencia.dart';
import 'package:bytebank/Widgets/editor.dart';
import 'package:flutter/material.dart';
import 'package:flutter/widgets.dart';

class FormularioTransferencia extends StatefulWidget {
  @override
  _FormularioTransferenciaState createState() => _FormularioTransferenciaState();
}

class _FormularioTransferenciaState extends State<FormularioTransferencia> {
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
        child: SingleChildScrollView(
          child: Column(
            children: <Widget>[
              Editor(
                  controlador: _controladorNumeroConta,
                  rotulo: 'Número da conta',
                  dica: '0000',
                  icone: Icons.account_balance),
              Editor(
                  controlador: _controladorValor,
                  rotulo: 'Valor',
                  dica: '00,00',
                  icone: Icons.monetization_on),
              RaisedButton(
                child: Text('Confirmar'),
                color: Colors.blueAccent,
                textColor: Colors.white,
                onPressed: () => _addTransferencia(context),
              ),
            ],
          ),
        ),
      ),
    );
  }

  void _addTransferencia(context) {
    final int conta = int.tryParse(_controladorNumeroConta.text);
    final double valor = double.tryParse(_controladorValor.text);
    if (conta != null && valor != null && valor > 0.0) {
      final transferenciaCriada = Transferencia(valor, conta);
      Navigator.pop(context, transferenciaCriada);
    }
  }
}
