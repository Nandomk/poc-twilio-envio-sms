using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;


class Program
{
    static void Main(string[] args)
    {
        // Find your Account SID and Auth Token at twilio.com/console
        // and set the environment variables. See http://twil.io/secure
        string accountSid = "";
        string authToken = "";
        //Dados phone de envio DDI + DDD + PHONE
        string phoneSandbox = "";
        //Dados Destino DDI + DDD + PHONE
        string phoneDestino = "+551188888888";
        string mensagem = "Teste Paciente";

        TwilioClient.Init(accountSid, authToken);

        var message = MessageResource.Create(
            body: mensagem,
            from: new Twilio.Types.PhoneNumber(phoneSandbox),
            to: new Twilio.Types.PhoneNumber(phoneDestino)
        );

        Console.WriteLine(message.Body);
    }
}