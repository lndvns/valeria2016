﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.SqlClient;

namespace EscolaBruxos.Modelo
{
    public abstract class Model : IDisposable
    {
        protected SqlConnection conn;

        public Model()
        {
            string strConn = @"Data Source = localhost;
                Initial Catalog = escolaBruxosDB;
                Integrated Security = true";
            conn = new SqlConnection(strConn);
            conn.Open();

        }

        public void Dispose()
        {
            conn.Close();
        }

    }
}