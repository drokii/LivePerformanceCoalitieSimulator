﻿using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LivePerformanceCoalitieSimulator.Objects;
using MySql.Data.MySqlClient;

namespace LivePerformanceCoalitieSimulator.DB
{
    interface IDBConnector
    {
        MySqlDataAdapter FillTable(string query);
        List<string>[] GetParties();
        void ExecuteQuery(string query);
    }
}
