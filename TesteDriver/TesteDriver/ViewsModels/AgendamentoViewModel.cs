﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using TesteDriver.Models;
using Xamarin.Forms;

namespace TesteDriver.ViewsModels
{
    public class AgendamentoViewModel
    {
        /// <summary>
        /// Variaveis e constantes 
        /// </summary>
        /// 
        #region Variaveis e constantes

        public Agendamento Agendamento { get; set; }

        public Veiculo Veiculo
        {
            get
            {
                return Agendamento.Veiculo;
            }

            set
            {
                Agendamento.Veiculo = value;
            }
        }

        public string Nome
        {
            get
            {
                return Agendamento.Nome;
            }

            set
            {
                Agendamento.Nome = value;
            }
        }
        public string Fone
        {
            get
            {
                return Agendamento.Fone;
            }

            set
            {
                Agendamento.Fone = value;
            }
        }
        public string Email
        {
            get
            {
                return Agendamento.Email;
            }

            set
            {
                Agendamento.Email = value;
            }
        }

        public DateTime DataAgendamento
        {
            get
            {
                return Agendamento.DataAgendamento;
            }
            set
            {
                Agendamento.DataAgendamento = value;
            }
        }

        public TimeSpan HoraAgendamento
        {
            get
            {
                return Agendamento.HoraAgendamento;
            }
            set
            {
                Agendamento.HoraAgendamento = value;
            }
        }

        #endregion

        public AgendamentoViewModel(Veiculo _veiculo)
        {
            this.Agendamento = new Agendamento();
            Agendamento.Veiculo = _veiculo;
            AgendamentoComando = new Command(() =>
           {
               MessagingCenter.Send<Agendamento>(this.Agendamento, "Agendamento");
           });
        }

        public ICommand AgendamentoComando { get; set; }
    }
}
