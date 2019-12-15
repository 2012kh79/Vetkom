using System;
using System.Data.SqlClient;

namespace Kursovoy_proekt
{
    class DBProcedures
    {
        public SqlCommand cmd = new SqlCommand("Empty", Registry_Class.sql);

        public void spConfiguration(string spName)
        {
            cmd.CommandText = spName;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        }



        public void spPostavshik_Insert(string Naimenovanie_postavshik, string INN)
        {
            spConfiguration("Postavshik_Insert");
            try
            {
                cmd.Parameters.AddWithValue("@Naimenovanie_postavshik", Naimenovanie_postavshik);
                cmd.Parameters.AddWithValue("@INN_postavshik", INN);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spPostavshik_Update(Int32 ID_Postavshik, string Naimenovanie_postavshik, string INN)
        {
            spConfiguration("Postavshik_Update");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Postavshik", ID_Postavshik);
                cmd.Parameters.AddWithValue("@Naimenovanie_postavshik", Naimenovanie_postavshik);
                cmd.Parameters.AddWithValue("@INN_postavshik", INN);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spPostavshik_Delete(Int32 ID_Postavshik)
        {
            spConfiguration("Postavshik_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Postavshik", ID_Postavshik);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch 
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spTovar_Insert(string Nazv_tovar, string Data_proizv, Int32 Postavshik_ID)
        {
            spConfiguration("Tovar_Insert");
            try
            {
                cmd.Parameters.AddWithValue("@Nazv_tovar", Nazv_tovar);
                cmd.Parameters.AddWithValue("@Data_proizv", Data_proizv);
                cmd.Parameters.AddWithValue("@Postavshik_ID", Postavshik_ID);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch 
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spTovar_Update(Int32 ID_Tovar, string Nazv_tovar, string Data_proizv, Int32 Postavshik_ID)
        {
            spConfiguration("Tovar_Update");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Tovar", ID_Tovar);
                cmd.Parameters.AddWithValue("@Nazv_tovar", Nazv_tovar);
                cmd.Parameters.AddWithValue("@Data_proizv", Data_proizv);
                cmd.Parameters.AddWithValue("@Postavshik_ID", Postavshik_ID);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spTovar_Delete(Int32 ID_Tovar)
        {
            spConfiguration("Tovar_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Tovar", ID_Tovar);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spJournal_postupleniya_tovarov_Insert(string Data_postupleniya, Int32 Tovar_ID)
        {
            spConfiguration("Journal_postupleniya_tovarov_Insert");
            try
            {
                cmd.Parameters.AddWithValue("@Data_postupleniya", Data_postupleniya);
                cmd.Parameters.AddWithValue("@Tovar_ID", Tovar_ID);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spJournal_postupleniya_tovarov_Update(Int32 ID_JPT, string Data_postupleniya, Int32 Tovar_ID)
        {
            spConfiguration("Journal_postupleniya_tovarov_Update");
            try
            {
                cmd.Parameters.AddWithValue("@ID_JPT", ID_JPT);
                cmd.Parameters.AddWithValue("@Data_postupleniya", Data_postupleniya);
                cmd.Parameters.AddWithValue("@Tovar_ID", Tovar_ID);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spJournal_postupleniya_tovarov_Delete(Int32 ID_JPT)
        {
            spConfiguration("Journal_postupleniya_tovarov_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_JPT", ID_JPT);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spTovarno_transportnaya_nakladnaya_Insert(string Fam_gruzootpravitel, string Imya_gruzootpravitel, string Otch_gruzootpravitel, Int32 Tovar_ID)
        {
            spConfiguration("Tovarno_transportnaya_nakladnaya_Insert");
            try
            {
                cmd.Parameters.AddWithValue("@Fam_gruzootpravitel", Fam_gruzootpravitel);
                cmd.Parameters.AddWithValue("@Imya_gruzootpravitel", Imya_gruzootpravitel);
                cmd.Parameters.AddWithValue("@Otch_gruzootpravitel", Otch_gruzootpravitel);
                cmd.Parameters.AddWithValue("@Tovar_ID", Tovar_ID);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spTovarno_transportnaya_nakladnaya_Update(Int32 ID_TTN, string Fam_gruzootpravitel, string Imya_gruzootpravitel, string Otch_gruzootpravitel, Int32 Tovar_ID)
        {
            spConfiguration("Tovarno_transportnaya_nakladnaya_Update");
            try
            {
                cmd.Parameters.AddWithValue("@ID_TTN", ID_TTN);
                cmd.Parameters.AddWithValue("@Fam_gruzootpravitel", Fam_gruzootpravitel);
                cmd.Parameters.AddWithValue("@Imya_gruzootpravitel", Imya_gruzootpravitel);
                cmd.Parameters.AddWithValue("@Otch_gruzootpravitel", Otch_gruzootpravitel);
                cmd.Parameters.AddWithValue("@Tovar_ID", Tovar_ID);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spTovarno_transportnaya_nakladnaya_Delete(Int32 ID_TTN)
        {
            spConfiguration("Tovarno_transportnaya_nakladnaya_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_TTN", ID_TTN);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spSertificat_sootv_Insert(string Fam_prov, string Imya_prov, string Otch_prov, string Podlinost)
        {
            spConfiguration("Sertificat_sootv_Insert");
            try
            {
                cmd.Parameters.AddWithValue("@Fam_prov", Fam_prov);
                cmd.Parameters.AddWithValue("@Imya_prov", Imya_prov);
                cmd.Parameters.AddWithValue("@Otch_prov", Otch_prov);
                cmd.Parameters.AddWithValue("@Podlinost", Podlinost);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spSertificat_sootv_Update(Int32 ID_Sertificat, string Fam_prov, string Imya_prov, string Otch_prov, string Podlinost)
        {
            spConfiguration("Sertificat_sootv_Update");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Sertificat", ID_Sertificat);
                cmd.Parameters.AddWithValue("@Fam_prov", Fam_prov);
                cmd.Parameters.AddWithValue("@Imya_prov", Imya_prov);
                cmd.Parameters.AddWithValue("@Otch_prov", Otch_prov);
                cmd.Parameters.AddWithValue("@Podlinost", Podlinost);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spSertificat_sootv_Delete(Int32 ID_Sertificat)
        {
            spConfiguration("Sertificat_sootv_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Sertificat", ID_Sertificat);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spTovary_prosh_proverku_Insert(int Kol_tovara, string Data_otsenky, string Vremya_otsenky, Int32 Tovar_ID, Int32 Sertificat_ID)
        {
            spConfiguration("Tovary_prosh_proverku_Insert");
            try
            {
                cmd.Parameters.AddWithValue("@Kol_tovara", Kol_tovara);
                cmd.Parameters.AddWithValue("@Data_otsenky", Data_otsenky);
                cmd.Parameters.AddWithValue("@Vremya_otsenky", Vremya_otsenky);
                cmd.Parameters.AddWithValue("@Tovar_ID", Tovar_ID);
                cmd.Parameters.AddWithValue("@Sertificat_ID", Sertificat_ID);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spTovary_prosh_proverku_Update(Int32 ID_TPP, int Kol_tovara, string Data_otsenky, string Vremya_otsenky, Int32 Tovar_ID, Int32 Sertificat_ID)
        {
            spConfiguration("Tovary_prosh_proverku_Update");
            try
            {
                cmd.Parameters.AddWithValue("@ID_TPP", ID_TPP);
                cmd.Parameters.AddWithValue("@Kol_tovara", Kol_tovara);
                cmd.Parameters.AddWithValue("@Data_otsenky", Data_otsenky);
                cmd.Parameters.AddWithValue("@Vremya_otsenky", Vremya_otsenky);
                cmd.Parameters.AddWithValue("@Tovar_ID", Tovar_ID);
                cmd.Parameters.AddWithValue("@Sertificat_ID", Sertificat_ID);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spTovary_prosh_proverku_Delete(Int32 ID_TPP)
        {
            spConfiguration("Tovary_prosh_proverku_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_TPP", ID_TPP);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spSort_tovary_Insert(string Oblast_primeneniya, string Naim_sklada, string Srok_hran_ot, string Srok_hran_do, Int32 TPP_ID)
        {
            spConfiguration("Sort_tovary_Insert");
            try
            {
                cmd.Parameters.AddWithValue("@Oblast_primeneniya", Oblast_primeneniya);
                cmd.Parameters.AddWithValue("@Naim_sklada", Naim_sklada);
                cmd.Parameters.AddWithValue("@Srok_hran_ot", Srok_hran_ot);
                cmd.Parameters.AddWithValue("@Srok_hran_do", Srok_hran_do);
                cmd.Parameters.AddWithValue("@TPP_ID", TPP_ID);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spSort_tovary_Update(Int32 ID_Sort, string Oblast_primeneniya, string Naim_sklada, string Srok_hran_ot, string Srok_hran_do, Int32 TPP_ID)
        {
            spConfiguration("Sort_tovary_Update");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Sort", ID_Sort);
                cmd.Parameters.AddWithValue("@Oblast_primeneniya", Oblast_primeneniya);
                cmd.Parameters.AddWithValue("@Naim_sklada", Naim_sklada);
                cmd.Parameters.AddWithValue("@Srok_hran_ot", Srok_hran_ot);
                cmd.Parameters.AddWithValue("@Srok_hran_do", Srok_hran_do);
                cmd.Parameters.AddWithValue("@TPP_ID", TPP_ID);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spSort_tovary_Delete(Int32 ID_Sort)
        {
            spConfiguration("Sort_tovary_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Sort", ID_Sort);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spKlient_Insert(string Login_Klient, string Fam_Klient, string Imya_Klient, string Otch_Klient, string Mail)
        {
            spConfiguration("Klient_Insert");
            try
            {
                cmd.Parameters.AddWithValue("@Login_Klient", Login_Klient);
                cmd.Parameters.AddWithValue("@Fam_Klient", Fam_Klient);
                cmd.Parameters.AddWithValue("@Imya_Klient", Imya_Klient);
                cmd.Parameters.AddWithValue("@Otch_Klient", Otch_Klient);
                cmd.Parameters.AddWithValue("@Mail", Mail);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spKlient_Update(string Login_Klient, string Fam_Klient, string Imya_Klient, string Otch_Klient, string Mail)
        {
            spConfiguration("Klient_Update");
            try
            {
                cmd.Parameters.AddWithValue("@Login_Klient", Login_Klient);
                cmd.Parameters.AddWithValue("@Fam_Klient", Fam_Klient);
                cmd.Parameters.AddWithValue("@Imya_Klient", Imya_Klient);
                cmd.Parameters.AddWithValue("@Otch_Klient", Otch_Klient);
                cmd.Parameters.AddWithValue("@Mail", Mail);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spKlient_Delete(Int32 ID_Klient)
        {
            spConfiguration("Klient_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Klient", ID_Klient);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spZakazany_tovary_Insert(string Sposob_dostavki, int Kol_zakaz_tovar, string Klient_Login, Int32 Sort_tovar_ID)
        {
            spConfiguration("Zakazany_tovary_Insert");
            try
            {
                cmd.Parameters.AddWithValue("@Sposob_dostavki", Sposob_dostavki);
                cmd.Parameters.AddWithValue("@Kol_zakaz_tovar", Kol_zakaz_tovar);
                cmd.Parameters.AddWithValue("@Klient_Login", Klient_Login);
                cmd.Parameters.AddWithValue("@Sort_tovar_ID", Sort_tovar_ID);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spZakazany_tovary_Update(Int32 ID_Zakaz, string Sposob_dostavki, int Kol_zakaz_tovar, string Klient_Login, Int32 Sort_tovar_ID)
        {
            spConfiguration("Zakazany_tovary_Update");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Zakaz", ID_Zakaz);
                cmd.Parameters.AddWithValue("@Sposob_dostavki", Sposob_dostavki);
                cmd.Parameters.AddWithValue("@Kol_zakaz_tovar", Kol_zakaz_tovar);
                cmd.Parameters.AddWithValue("@Klient_Login", Klient_Login);
                cmd.Parameters.AddWithValue("@Sort_tovar_ID", Sort_tovar_ID);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spZakazany_tovary_Delete(Int32 ID_Zakaz)
        {
            spConfiguration("Zakazany_tovary_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Zakaz", ID_Zakaz);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spJournal_ucheta_dvizheniya_tovara_na_sklade_Insert(string Fam_otv, string Imya_otv, string Otch_otv, double Rashod, double Prihod, Int32 Sort_tovary_ID)
        {
            spConfiguration("Journal_ucheta_dvizheniya_tovara_na_sklade_Insert");
            try
            {
                cmd.Parameters.AddWithValue("@Fam_otv", Fam_otv);
                cmd.Parameters.AddWithValue("@Imya_otv", Imya_otv);
                cmd.Parameters.AddWithValue("@Otch_otv", Otch_otv);
                cmd.Parameters.AddWithValue("@Rashod", Rashod);
                cmd.Parameters.AddWithValue("@Prihod", Prihod);
                cmd.Parameters.AddWithValue("@Sort_tovary_ID", Sort_tovary_ID);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spJournal_ucheta_dvizheniya_tovara_na_sklade_Update(Int32 ID_JUDTNS, string Fam_otv, string Imya_otv, string Otch_otv, double Rashod, double Prihod, Int32 Sort_tovary_ID)
        {
            spConfiguration("Journal_ucheta_dvizheniya_tovara_na_sklade_Update");
            try
            {
                cmd.Parameters.AddWithValue("@ID_JUDTNS", ID_JUDTNS);
                cmd.Parameters.AddWithValue("@Fam_otv", Fam_otv);
                cmd.Parameters.AddWithValue("@Imya_otv", Imya_otv);
                cmd.Parameters.AddWithValue("@Otch_otv", Otch_otv);
                cmd.Parameters.AddWithValue("@Rashod", Rashod);
                cmd.Parameters.AddWithValue("@Prihod", Prihod);
                cmd.Parameters.AddWithValue("@Sort_tovary_ID", Sort_tovary_ID);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spJournal_ucheta_dvizheniya_tovara_na_sklade_Delete(Int32 ID_JUDTNS)
        {
            spConfiguration("Journal_ucheta_dvizheniya_tovara_na_sklade_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_JUDTNS", ID_JUDTNS);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spOtchet_o_sprose_i_fact_nalichii_tovarov_Insert(string Fam_buhgalter, string Imya_buhgalter, string Otch_buhgalter, string Data_form_otchet, Int32 JUDTNS_ID, Int32 Zakaz_tovary_ID)
        {
            spConfiguration("Otchet_o_sprose_i_fact_nalichii_tovarov_Insert");
            try
            {
                cmd.Parameters.AddWithValue("@Fam_buhgalter", Fam_buhgalter);
                cmd.Parameters.AddWithValue("@Imya_buhgalter", Imya_buhgalter);
                cmd.Parameters.AddWithValue("@Otch_buhgalter", Otch_buhgalter);
                cmd.Parameters.AddWithValue("@Data_form_otchet", Data_form_otchet);
                cmd.Parameters.AddWithValue("@JUDTNS_ID", JUDTNS_ID);
                cmd.Parameters.AddWithValue("@Zakaz_tovary_ID", Zakaz_tovary_ID);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spOtchet_o_sprose_i_fact_nalichii_tovarov_Update(Int32 ID_OOSIFNT, string Fam_buhgalter, string Imya_buhgalter, string Otch_buhgalter, string Data_form_otchet, Int32 JUDTNS_ID, Int32 Zakaz_tovary_ID)
        {
            spConfiguration("Otchet_o_sprose_i_fact_nalichii_tovarov_Update");
            try
            {
                cmd.Parameters.AddWithValue("@ID_OOSIFNT", ID_OOSIFNT);
                cmd.Parameters.AddWithValue("@Fam_buhgalter", Fam_buhgalter);
                cmd.Parameters.AddWithValue("@Imya_buhgalter", Imya_buhgalter);
                cmd.Parameters.AddWithValue("@Otch_buhgalter", Otch_buhgalter);
                cmd.Parameters.AddWithValue("@Data_form_otchet", Data_form_otchet);
                cmd.Parameters.AddWithValue("@JUDTNS_ID", JUDTNS_ID);
                cmd.Parameters.AddWithValue("@Zakaz_tovary_ID", Zakaz_tovary_ID);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spOtchet_o_sprose_i_fact_nalichii_tovarov_Delete(Int32 ID_OOSIFNT)
        {
            spConfiguration("Otchet_o_sprose_i_fact_nalichii_tovarov_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_OOSIFNT", ID_OOSIFNT);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spSoprovoditelny_document_Insert(string Adres_Postavshika, string Adres_zakazchika, Int32 Postavshik_ID)
        {
            spConfiguration("Soprovoditelny_document_Insert");
            try
            {
                cmd.Parameters.AddWithValue("@Adres_Postavshika", Adres_Postavshika);
                cmd.Parameters.AddWithValue("@Adres_zakazchika", Adres_zakazchika);
                cmd.Parameters.AddWithValue("@Postavshik_ID", Postavshik_ID);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spSoprovoditelny_document_Update(Int32 ID_Sopr, string Adres_Postavshika, string Adres_zakazchika, Int32 Postavshik_ID)
        {
            spConfiguration("Soprovoditelny_document_Update");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Sopr", ID_Sopr);
                cmd.Parameters.AddWithValue("@Adres_Postavshika", Adres_Postavshika);
                cmd.Parameters.AddWithValue("@Adres_zakazchika", Adres_zakazchika);
                cmd.Parameters.AddWithValue("@Postavshik_ID", Postavshik_ID);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spSoprovoditelny_document_Delete(Int32 ID_Sopr)
        {
            spConfiguration("Soprovoditelny_document_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Sopr", ID_Sopr);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spUkomplektovany_tovar_Insert(string Data_kompl, Int32 Sopr_ID, Int32 Zakaz_tovary_ID)
        {
            spConfiguration("Ukomplektovany_tovar_Insert");
            try
            {
                cmd.Parameters.AddWithValue("@Data_kompl", Data_kompl);
                cmd.Parameters.AddWithValue("@Sopr_ID", Sopr_ID);
                cmd.Parameters.AddWithValue("@Zakaz_tovary_ID", Zakaz_tovary_ID);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spUkomplektovany_tovar_Update(Int32 ID_Kompl, string Data_kompl, Int32 Sopr_ID, Int32 Zakaz_tovary_ID)
        {
            spConfiguration("Ukomplektovany_tovar_Update");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Kompl", ID_Kompl);
                cmd.Parameters.AddWithValue("@Data_kompl", Data_kompl);
                cmd.Parameters.AddWithValue("@Sopr_ID", Sopr_ID);
                cmd.Parameters.AddWithValue("@Zakaz_tovary_ID", Zakaz_tovary_ID);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spUkomplektovany_tovar_Delete(Int32 ID_Kompl)
        {
            spConfiguration("Ukomplektovany_tovar_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Kompl", ID_Kompl);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spShet_facture_Insert(double Tsena_za_zakazany_tovar, string Data_form_shet, Int32 Zakaz_tovary_ID, Int32 TTN_ID)
        {
            spConfiguration("Shet_facture_Insert");
            try
            {
                cmd.Parameters.AddWithValue("@Tsena_za_zakazany_tovar", Tsena_za_zakazany_tovar);
                cmd.Parameters.AddWithValue("@Data_form_shet", Data_form_shet);
                cmd.Parameters.AddWithValue("@Zakaz_tovary_ID", Zakaz_tovary_ID);
                cmd.Parameters.AddWithValue("@TTN_ID", TTN_ID);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spShet_facture_Update(Int32 ID_Shet, double Tsena_za_zakazany_tovar, string Data_form_shet, Int32 Zakaz_tovary_ID, Int32 TTN_ID)
        {
            spConfiguration("Shet_facture_Update");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Shet", ID_Shet);
                cmd.Parameters.AddWithValue("@Tsena_za_zakazany_tovar", Tsena_za_zakazany_tovar);
                cmd.Parameters.AddWithValue("@Data_form_shet", Data_form_shet);
                cmd.Parameters.AddWithValue("@Zakaz_tovary_ID", Zakaz_tovary_ID);
                cmd.Parameters.AddWithValue("@TTN_ID", TTN_ID);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spShet_facture_Delete(Int32 ID_Shet)
        {
            spConfiguration("Shet_facture_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Shet", ID_Shet);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spPeredany_tovar_Insert(string Data_peredachi, string Vremya_peredachi, Int32 Kompl_tovary_ID, Int32 Shet_ID)
        {
            spConfiguration("Peredany_tovar_Insert");
            try
            {
                cmd.Parameters.AddWithValue("@Data_peredachi", Data_peredachi);
                cmd.Parameters.AddWithValue("@Vremya_peredachi", Vremya_peredachi);
                cmd.Parameters.AddWithValue("@Kompl_tovary_ID", Kompl_tovary_ID);
                cmd.Parameters.AddWithValue("@Shet_ID", Shet_ID);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spPeredany_tovar_Update(Int32 ID_Peredany_tovar, string Data_peredachi, string Vremya_peredachi, Int32 Kompl_tovary_ID, Int32 Shet_ID)
        {
            spConfiguration("Peredany_tovar_Update");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Peredany_tovar", ID_Peredany_tovar);
                cmd.Parameters.AddWithValue("@Data_peredachi", Data_peredachi);
                cmd.Parameters.AddWithValue("@Vremya_peredachi", Vremya_peredachi);
                cmd.Parameters.AddWithValue("@Kompl_tovary_ID", Kompl_tovary_ID);
                cmd.Parameters.AddWithValue("@Shet_ID", Shet_ID);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spPeredany_tovar_Delete(Int32 ID_Peredany_tovar)
        {
            spConfiguration("Peredany_tovar_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Peredany_tovar", ID_Peredany_tovar);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spAccount_Insert(string Login_Account, string Parol_Account, Int32 Role_ID)
        {
            spConfiguration("Account_New_User");
            try
            {
                cmd.Parameters.AddWithValue("@Login_Account", Login_Account);
                cmd.Parameters.AddWithValue("@Parol_Account", Parol_Account);
                cmd.Parameters.AddWithValue("@Role_ID", Role_ID);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spAccount_Update(string Login_Account, string Parol_Account, Int32 Role_ID)
        {
            spConfiguration("Account_Update_User");
            try
            {
                cmd.Parameters.AddWithValue("@Login_Account", Login_Account);
                cmd.Parameters.AddWithValue("@Parol_Account", Parol_Account);
                cmd.Parameters.AddWithValue("@Role_ID", Role_ID);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spAccount_Delete(string Login_Account)
        {
            spConfiguration("Account_Delete_User");
            try
            {
                cmd.Parameters.AddWithValue("@Login_Account", Login_Account);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spRole_Insert(string Role_name, bool Otchet, bool Sklad, bool Zakaz,
            bool Kabinet, bool Inf_o_programe, bool Inf_ob_avtore)
        {
            spConfiguration("Role_Insert");
            try
            {
                cmd.Parameters.AddWithValue("@Role_name", Role_name);
                cmd.Parameters.AddWithValue("@Otchet", Otchet);
                cmd.Parameters.AddWithValue("@Sklad", Sklad);
                cmd.Parameters.AddWithValue("@Zakaz", Zakaz);
                cmd.Parameters.AddWithValue("@Kabinet", Kabinet);
                cmd.Parameters.AddWithValue("@Inf_o_programe", Inf_o_programe);
                cmd.Parameters.AddWithValue("@Inf_ob_avtore", Inf_ob_avtore);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spRole_Update(Int32 ID_Role, string Role_name, byte Otchet, byte Sklad, byte Zakaz,
            byte Kabinet, byte Inf_o_programe, byte Inf_ob_avtore)
        {
            spConfiguration("Role_Update");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Role", ID_Role);
                cmd.Parameters.AddWithValue("@Role_name", Role_name);
                cmd.Parameters.AddWithValue("@Otchet", Otchet);
                cmd.Parameters.AddWithValue("@Sklad", Sklad);
                cmd.Parameters.AddWithValue("@Zakaz", Zakaz);
                cmd.Parameters.AddWithValue("@Kabinet", Kabinet);
                cmd.Parameters.AddWithValue("@Inf_o_programe", Inf_o_programe);
                cmd.Parameters.AddWithValue("@Inf_ob_avtore", Inf_ob_avtore);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void spRole_Delete(Int32 ID_Role)
        {
            spConfiguration("Role_Delete");
            try
            {
                cmd.Parameters.AddWithValue("@ID_Role", ID_Role);
                Registry_Class.sql.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch
            {

            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }
    }
}
