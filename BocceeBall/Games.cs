﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BocceeBall
{
    class Games
    {
        public int ID { get; set; }

        public int? HomeTeamID  { get; set; }
        public Teams HomeTeam { get; set; }

       public int? AwayTeamID { get; set; }
       public Teams AwayTeam { get; set; }

        public int HomeScore { get; set; }
        public int AwayScore { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }
    }
}
