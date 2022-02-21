using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleHoras.Model
{
    public class Dia
    {
        public long Id { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan HoraUm { get; set; }
        public TimeSpan HoraDois { get; set; }
        public TimeSpan HoraTres { get; set; }
        public TimeSpan HoraQuatro { get; set; }
        public TimeSpan Intervalo { get; set; }
        public TimeSpan TotalHoras { get; set; }

        public static TimeSpan CalculoIntervalor(TimeSpan horaDois, TimeSpan horaTres) => horaTres - horaDois;

        public static TimeSpan CalculoTotalHora(TimeSpan horaUm, TimeSpan horaQuatro, TimeSpan intervalo)
        {
            var result = horaQuatro - horaUm;
            return result - intervalo;
        }
    }
}
