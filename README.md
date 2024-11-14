# Teste Credit-Suisse

Este repositório contém o Teste:

Um banco possui uma carteira com milhares de operações que precisam ser categorizadas. Uma operação é uma negociação comercial entre o banco e um cliente. Uma operação possui várias características, incluindo:

double Value { get; } // valor da transação em dólares
string ClientSector { get; } //setor do cliente, que pode ser "Public" (Público) ou "Private" (Privado)
DateTime NextPaymentDate { get; } // data do próximo pagamento do cliente para o banco

Regras:

EXPIRED: Operações cuja data do próximo pagamento está atrasada em mais de 30 dias, com base em uma data de referência que será fornecida.
HIGHRISK: Operações com valor superior a 1.000.000 e cliente do setor Privado.
MEDIUMRISK: Operações com valor superior a 1.000.000 e cliente do setor Público.
POLITICALLYEXPOSED : incluido posteriormente com a regra se e pessoa politicamente "exposta", true ou "false" .

- **Padrao utilizado**: Foi utilizado o padrao Chain of Responsability para categorizar as regras e seguir o SOLID, mais preisamente o OCP, para que ao incluir a nova regra de politicamente exposto eu apenas extenda a implentacao sem alterar o funcionamento das demais regras.