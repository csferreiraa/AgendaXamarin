using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace AgendaContato.Model
{
    [Table("Agenda")]
    public class Agenda
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public string TipoTelofone { get; set; }
        public string Email { get; set; }
    }
}
