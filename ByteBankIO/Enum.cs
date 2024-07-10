using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankIO
{
    internal class Enum
    {
        static void Main()
        {

            var btnCancelar = new Botao();
            btnCancelar.Texto = "Cancelar";
            btnCancelar.Cor = CoresBotao.Azul;


            var numero = 0;
            CoresBotao cor1 = (CoresBotao)numero;

            Console.WriteLine(CoresBotao.Azul == (CoresBotao)128);
            Console.WriteLine(CoresBotao.Vermelho == (CoresBotao)256); 
            Console.WriteLine(CoresBotao.Verde == (CoresBotao)512); 

            Console.WriteLine(CoresBotao.Verde == (CoresBotao)1); 
        }

        class Botao
        {
            public String Texto { get; set; }
            public CoresBotao Cor { get; set; }
        }

        enum CoresBotao
        {
            Azul = 128,
            Vermelho = 256,
            Verde = 512
        }

    }
}
