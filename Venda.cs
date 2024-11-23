using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Venda
    {
        private String ConStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=bancovendas;Integrated Security=True";

        public DTO.Vendas Select()
        {
            DTO.Vendas vendas = new DTO.Vendas();
            SqlConnection con = new SqlConnection(ConStr);
            string sql = "SelecionaVenda";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DTO.Venda v = new DTO.Venda();

                v.DataVenda = dr.GetDateTime(0);
                v.IdPessoa = dr.GetInt32(1);
                v.NumeroNotaFiscal = dr.GetInt32(2);
                vendas.Add(v);




            }

            con.Close();

            return vendas;
        }

        public void Update(DTO.Venda v)
        {
            SqlConnection con = new SqlConnection(ConStr);
            string sql = "AtualizaVenda";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@DataVenda", v.DataVenda);
            cmd.Parameters.AddWithValue("@IdPessoa", v.IdPessoa);
            cmd.Parameters.AddWithValue("@NumNotaFiscal", v.NumeroNotaFiscal);



            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        public void Insert(DTO.Venda v)
        {
            SqlConnection con = new SqlConnection(ConStr);
            string sql = "InsereVenda";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@DataVenda", v.DataVenda);
            cmd.Parameters.AddWithValue("@IdPessoa", v.IdPessoa);
            cmd.Parameters.AddWithValue("@NumNotaFiscal", v.NumeroNotaFiscal);


            try
            {
                con.Open();
                cmd.ExecuteNonQuery();

            }
            finally
            {
                con.Close();
            }
        }

        public void Delete(DTO.Venda v)
        {
            SqlConnection con = new SqlConnection(ConStr);
            string sql = "DeleteVenda";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", v.IdVenda);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
