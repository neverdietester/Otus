﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib;
using Npgsql;

namespace Homework_16
{
    class Config
    {
        public static string SqlConnectionString = "User ID=postgres;Password=123456;Host=localhost;Port=8000;Database=clusterdb;";
    }
}