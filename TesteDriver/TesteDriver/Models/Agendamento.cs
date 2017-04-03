﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TesteDriver.Models
{
    public class Agendamento
    {
        public Veiculo Veiculo { get; set; }

        public string Nome { get; set; }
        public string Fone { get; set; }
        public string Email { get; set; }

        public DateTime DataAgendamento = DateTime.Today;

        public TimeSpan HoraAgendamento { get; set; }
    }
}
