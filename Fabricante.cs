using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFerramenta0030482423011
{
    class Fabricante
    {
        public int IdFabricante { get; set; }

        public int NomeFantasia { get; set; }

        public DataTable Listar()
        {
            SqlDataAdapter daFabricante;
            DataTable dtFabricante = new DataTable();
            try
            {
                daFabricante = new SqlDataAdapter("SELECT * FROM FABRICANTE",frmPrincipal.conexao);
                daFabricante.Fill(dtFabricante);
                daFabricante.FillSchema(dtFabricante, SchemaType.Source);
                return dtFabricante;
            } catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Salvar()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;
                mycommand = new SqlCommand("INSERT INTO FABRICANTE VALUES (@nomeFantasia)", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@nomeFantasia", SqlDbType.VarChar));

                mycommand.Parameters["@NomeFantasia"].Value = NomeFantasia;
               retorno= mycommand.ExecuteNonQuery();
            } catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }

        public int Alterar()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;

                mycommand = new SqlCommand("UPDATE FABRICANTE SET nomeFantasia=" +
                    " @nomeFanatasia WHERE id=@idfabricante", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@idfabricante", SqlDbType.Int));

                mycommand.Parameters.Add(new SqlParameter("@nomeFantasia", SqlDbType.VarChar));

                mycommand.Parameters["@idfabricante"].Value = IdFabricante;
                mycommand.Parameters["@nomeFantasia"].Value = NomeFantasia;
                retorno = mycommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }

        public int Excluir()
        {
            int retorno = 0;
            try
            {
                SqlCommand mycommand;
                mycommand = new SqlCommand("DELETE FROM FABRICANTE WHERE id=@idfabricante", frmPrincipal.conexao);
                mycommand.Parameters.Add(new SqlParameter("@idfabricante", SqlDbType.Int));
                mycommand.Parameters["@idfabricante"].Value = IdFabricante;

                retorno = mycommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }
    }
}

