using System;

namespace TradeApp
{
    public interface ITrade
    {
        double Value { get; } //valor da transação em dólares
        string ClientSector { get; } //setor do cliente
        DateTime NextPaymentDate { get; } //Data do próximo pagamento esperado
        bool IsPoliticallyExposed { get; } //Pessoa politicamente exposta
    }
}
