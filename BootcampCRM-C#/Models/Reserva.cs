using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootcampCRM_C_.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() {}

        public Reserva (int diasReservados){
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes){
            if (Suite.Capacidade >= hospedes.Count()){
                Hospedes = hospedes;
            }
            else {
                throw new Exception ("A capacidade da suíte é menor que o número de hóspedes recebido");
            }
        }

        public void CadastrarSuite(Suite suite){
            Suite = suite;
        }

        public int ObterQuantidadeDeHospedes(){
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria (){
            decimal valor = DiasReservados * Suite.ValorDiaria;
            decimal desconto = 0.10M;

            if (DiasReservados >= 10){
                valor = valor - (valor * desconto);
            }

            return valor;

        }


    }
}