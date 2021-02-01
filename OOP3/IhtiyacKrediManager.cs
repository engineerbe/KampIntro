using System;
namespace OOP3
{
    class IhtiyacKrediManager : IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Ihtiyac kredisi odeme plani hesaplandi.");
        }
    }
}
