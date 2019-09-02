using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interage.Logistica.Api.Models
{
    public class RegistrarViagemTraRequest
    {
        public string operacao_id { get; set; }
        public string tipo_viagem { get; set; }
        public string percurso { get; set; }
        public string rastreada { get; set; }
        public string mercadoria_ou_produto_id { get; set; }
        public string valor_embarque { get; set; }
        public string codigo_liberacao { get; set; }
        public string numero_transporte { get; set; }
        public string origem_ID { get; set; }
        public string inicio_previsto_data { get; set; }
        public string inicio_previsto_hora { get; set; }
        public string inicio_real_data { get; set; }
        public string inicio_real_hora { get; set; }
        public string destino_ID { get; set; }
        public string fim_previsto_data { get; set; }
        public string fim_previsto_hora { get; set; }
        public string fim_real_data { get; set; }
        public string fim_real_hora { get; set; }
        public string transportador_cnpj { get; set; }
        public string motorista_cpf { get; set; }
        public string motorista2_cpf { get; set; }
        public string placa { get; set; }
        public string placa1 { get; set; }
        public string placa2 { get; set; }
        public string placa3 { get; set; }
        public string rota_id { get; set; }
        public string rota_descricao { get; set; }
        public string rota { get; set; }
    }
}