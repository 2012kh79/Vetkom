using System;
using System.Data.SqlClient;
using System.Data;

namespace Kursovoy_proekt
{
    class DataBaseTables
    {
        public SqlCommand command = new SqlCommand("", Registry_Class.sql);
        public SqlDependency dependency = new SqlDependency();
        public DataTable dtRole = new DataTable("Role");
        public DataTable dtAccount = new DataTable("Account");
        public DataTable dtPostavshik = new DataTable("Postavshik");
        public DataTable dtTovar = new DataTable("Tovar");
        public DataTable dtJournal_postupleniya_tovarov = new DataTable("Journal_postupleniya_tovarov");
        public DataTable dtTovarno_transportnaya_nakladnaya = new DataTable("Tovarno_transportnaya_nakladnaya");
        public DataTable dtSertificat_sootv = new DataTable("Sertificat_sootv");
        public DataTable dtTovary_prosh_proverku = new DataTable("Tovary_prosh_proverku");
        public DataTable dtSort_tovary = new DataTable("Sort_tovary");
        public DataTable dtKlient = new DataTable("Klient");
        public DataTable dtZakazany_tovary = new DataTable("Zakazany_tovary");
        public DataTable dtJournal_ucheta_dvizheniya_tovara_na_sklade = new DataTable("Journal_ucheta_dvizheniya_tovara_na_sklade");
        public DataTable dtOtchet_o_sprose_i_fact_nalichii_tovarov = new DataTable("Otchet_o_sprose_i_fact_nalichii_tovarov");
        public DataTable dtSoprovoditelny_document = new DataTable("Soprovoditelny_document");
        public DataTable dtUkomplektovany_tovar = new DataTable("Ukomplektovany_tovar");
        public DataTable dtShet_facture = new DataTable("Shet_facture");
        public DataTable dtPeredany_tovar = new DataTable("Peredany_tovar");
        public DataTable dtZakaz_tovar = new DataTable("Zakaz_tovara");
        public string qrRole = "select [ID_Role],[Role_name],[Otchet],[Sklad],[Zakaz],[Kabinet],[Inf_o_programe],[Inf_ob_avtore] from [Role]",
            qrAccount = "select [Login_Account],[Parol_Account],[Role_ID],[ID_Role],[Role_name],[Otchet],[Sklad],[Zakaz],[Kabinet],[Inf_o_programe],[Inf_ob_avtore] from [Account] inner join [Role] on [Role].[ID_Role] = [Account].[Role_ID]",
            qrPostavshik = "select [ID_Postavshik],[Naimenovanie_postavshik],[INN_postavshik] from [dbo].[Postavshik]",
            qrTovar = "select [ID_Tovar],[Nazv_tovar],[Data_proizv],[Postavshik_ID],[ID_Postavshik],[Naimenovanie_postavshik],[INN_postavshik] from [dbo].[Tovar] inner join [dbo].[Postavshik] on [dbo].[Postavshik].[ID_Postavshik] = [dbo].[Tovar].[Postavshik_ID]",
            qrJournal_postupleniya_tovarov = "select [ID_JPT],[Data_postupleniya],[Tovar_ID],[ID_Tovar],[Nazv_tovar],[Data_proizv] from [dbo].[Journal_postupleniya_tovarov] inner join [dbo].[Tovar] on [dbo].[Tovar].[ID_Tovar] = [dbo].[Journal_postupleniya_tovarov].[Tovar_ID]",
            qrTovarno_transportnaya_nakladnaya = "select [ID_TTN],[Fam_gruzootpravitel],[Imya_gruzootpravitel],[Otch_gruzootpravitel],[Tovar_ID],[Fam_gruzootpravitel]+' '+[Imya_gruzootpravitel]+' '+[Otch_gruzootpravitel] as \"Full_Name_Gruzootpravitel\",[ID_Tovar],[Nazv_tovar],[Data_proizv] from [dbo].[Tovarno_transportnaya_nakladnaya] inner join [dbo].[Tovar] on [dbo].[Tovar].[ID_Tovar] = [dbo].[Tovarno_transportnaya_nakladnaya].[Tovar_ID]",
            qrSertificat_sootv = "select [ID_Sertificat],[Fam_prov],[Imya_prov],[Otch_prov],[Podlinost],[Fam_prov]+' '+[Imya_prov]+' '+[Otch_prov] as \"Full_Name_Prov\"from [dbo].[Sertificat_sootv]",
            qrTovary_prosh_proverku = "select [ID_TPP],[Data_otsenky],[Vremya_otsenky],[Kol_tovara],[Tovar_ID],[Sertificat_ID],[ID_Tovar],[Nazv_tovar],[Data_proizv],[ID_Sertificat],[Podlinost],[Fam_prov]+' '+[Imya_prov]+' '+[Otch_prov] as \"Full_Name_Prov\" from [dbo].[Tovary_prosh_proverku] inner join [dbo].[Tovar] on [dbo].[Tovar].[ID_Tovar] = [dbo].[Tovary_prosh_proverku].[Tovar_ID] inner join [Sertificat_sootv] on [Sertificat_sootv].[ID_Sertificat] = [dbo].[Tovary_prosh_proverku].[Sertificat_ID]",
            qrSort_tovary = "select [ID_Sort],[Oblast_primeneniya],[Naim_sklada],[Srok_hran_ot],[Srok_hran_do],[TPP_ID],[ID_TPP],[Data_otsenky],[Vremya_otsenky],[Kol_tovara] from [dbo].[Sort_tovary] inner join [Tovary_prosh_proverku] on [Tovary_prosh_proverku].[ID_TPP] = [Sort_tovary].[TPP_ID]",
            qrKlient = "select [Login_Klient],[Fam_klient],[Otch_klient],[Mail],[Fam_Klient]+' '+[Imya_Klient]+' '+[Otch_Klient] as \"Full_name_Klient\" from [dbo].[Klient]",
            qrZakazany_tovary = "select [ID_Zakaz],[Sposob_dostavki],[Kol_zakaz_tovar],[Sort_tovar_ID],[Klient_Login],[ID_Sort],[Oblast_primeneniya],[Naim_sklada],[Srok_hran_ot],[Srok_hran_do],[Login_Klient],[Fam_Klient]+' '+[Imya_Klient]+' '+[Otch_Klient] as \"Full_name_Klient\",[Mail] from [Zakazany_tovary] inner join [dbo].[Klient] on [Klient].[Login_Klient] = [Zakazany_tovary].[Klient_Login] inner join [Sort_tovary] on [Sort_tovary].[ID_Sort] = [Zakazany_tovary].[Sort_tovar_ID]",
            qrJournal_ucheta_dvizheniya_tovara_na_sklade = "select [ID_JUDTNS],[Fam_otv],[Imya_otv],[Otch_otv],[Rashod],[Prihod],[Ostatok],[Sort_tovary_ID],[Fam_otv]+' '+[Imya_otv]+' '+[Otch_otv] as \"Full_name_Otv\",[ID_Sort],[Oblast_primeneniya],[Naim_sklada],[Srok_hran_ot],[Srok_hran_do] from [Journal_ucheta_dvizheniya_tovara_na_sklade] inner join [Sort_tovary] on [Sort_tovary].[ID_Sort] = [Journal_ucheta_dvizheniya_tovara_na_sklade].[Sort_tovary_ID]",
            qrOtchet_o_sprose_i_fact_nalichii_tovarov = "select [ID_OOSIFNT],[Fam_buhgalter],[Imya_buhgalter],[Otch_buhgalter],[Data_form_otchet],[JUDTNS_ID],[Zakaz_tovary_ID],[Fam_buhgalter]+' '+[Imya_buhgalter]+' '+[Otch_buhgalter] as \"Full_name_Buhgalter\",[ID_JUDTNS],[Fam_otv]+' '+[Imya_otv]+' '+[Otch_otv] as \"Full_name_otv\",[Rashod],[Prihod],[Ostatok],[ID_Zakaz],[Sposob_dostavki],[Kol_zakaz_tovar] from [Otchet_o_sprose_i_fact_nalichii_tovarov] inner join [Journal_ucheta_dvizheniya_tovara_na_sklade] on [Journal_ucheta_dvizheniya_tovara_na_sklade].[ID_JUDTNS] = [Otchet_o_sprose_i_fact_nalichii_tovarov].[JUDTNS_ID] inner join [Zakazany_tovary] on [Zakazany_tovary].[ID_Zakaz] = [Otchet_o_sprose_i_fact_nalichii_tovarov].[Zakaz_tovary_ID]",
            qrSoprovoditelny_document = "select [ID_Sopr],[Adres_postavshika],[Adres_zakazchika],[Postavshik_ID],[ID_Postavshik],[Naimenovanie_postavshik],[INN_postavshik] from [Soprovoditelny_document] inner join [Postavshik] on [Postavshik].[ID_Postavshik] = [Soprovoditelny_document].[Postavshik_ID]",
            qrUkomplektovany_tovar = "select [ID_Kompl],[Data_Kompl],[Zakaz_tovary_ID],[Sopr_ID],[ID_Zakaz],[Sposob_dostavki],[Kol_zakaz_tovar],[ID_Sopr],[Adres_postavshika],[Adres_zakazchika] from [Ukomplektovany_tovar] inner join [Zakazany_tovary] on [Zakazany_tovary].[ID_Zakaz] = [Ukomplektovany_tovar].[Zakaz_tovary_ID] inner join [Soprovoditelny_document] on [Soprovoditelny_document].[ID_Sopr] = [Ukomplektovany_tovar].[Sopr_ID]",
            qrShet_facture = "select [ID_Shet],[Data_form_shet],[Tsena_za_zakazany_tovar],[Zakaz_tovary_ID],[TTN_ID], [ID_Zakaz],[Sposob_dostavki],[Kol_zakaz_tovar], [ID_TTN],[Fam_gruzootpravitel]+' '+[Imya_gruzootpravitel]+' '+[Otch_gruzootpravitel] as \"Full_Name_Gruzootpravitel\" from [Shet_facture] inner join [Zakazany_tovary] on [Zakazany_tovary].[ID_Zakaz] = [Shet_facture].[Zakaz_tovary_ID] inner join [Tovarno_transportnaya_nakladnaya] on [Tovarno_transportnaya_nakladnaya].[ID_TTN] = [Shet_facture].[TTN_ID]",
            qrPeredany_tovar = "select [ID_Peredany_tovar],[Data_peredachi],[Vremya_peredachi],[Kompl_tovary_ID],[Shet_ID],[ID_Kompl],[Data_Kompl],[ID_Shet],[Data_form_shet],[Tsena_za_zakazany_tovar] from [Peredany_tovar] inner join [Shet_facture] on [Shet_facture].[ID_Shet] = [Peredany_tovar].[Shet_ID] inner join [Ukomplektovany_tovar] on [Ukomplektovany_tovar].[ID_Kompl] = [Peredany_tovar].[Kompl_tovary_ID]",
            qrZakaz_tovar = "select [Nazv_firm],[Nazv_tovar],[Kol_tovar],[Adres_dostavki] from [dbo].[Zakaz_tovara]";

        private void dtFill(DataTable table, string query)
        {
            try
            {
                command.Notification = null;
                command.CommandText = query;
                dependency.AddCommandDependency(command);
                SqlDependency.Start(Registry_Class.sql.ConnectionString);
                Registry_Class.sql.Open();
                table.Load(command.ExecuteReader());
                SqlDependency.Stop(Registry_Class.sql.ConnectionString);
            }
            catch (Exception ex)
            {
                Registry_Class.error_message += "\n"
                    + DateTime.Now.ToLongDateString() + ex.Message;
            }
            finally
            {
                Registry_Class.sql.Close();
            }
        }

        public void dtRoleFill()
        {
            dtFill(dtRole, qrRole);
        }

        public void dtZakaz_tovaraFill()
        {
            dtFill(dtZakaz_tovar, qrZakaz_tovar);
        }

        public void dtAccountFill()
        {
            dtFill(dtAccount, qrAccount);
        }

        public void dtPostavshikFill()
        {
            dtFill(dtPostavshik, qrPostavshik);
        }

        public void dtTovarFill()
        {
            dtFill(dtTovar, qrTovar);
        }

        public void dtJPTFill()
        {
            dtFill(dtJournal_postupleniya_tovarov, qrJournal_postupleniya_tovarov);
        }

        public void dtTTNFill()
        {
            dtFill(dtTovarno_transportnaya_nakladnaya, qrTovarno_transportnaya_nakladnaya);
        }

        public void dtSertificatFill()
        {
            dtFill(dtSertificat_sootv, qrSertificat_sootv);
        }

        public void dtTPPFill()
        {
            dtFill(dtTovary_prosh_proverku, qrTovary_prosh_proverku);
        }

        public void dtSortFill()
        {
            dtFill(dtSort_tovary, qrSort_tovary);
        }

        public void dtZakazFill()
        {
            dtFill(dtZakazany_tovary, qrZakazany_tovary);
        }

        public void dtKlientFill()
        {
            dtFill(dtKlient, qrKlient);
        }

        public void dtJUDTNSFill()
        {
            dtFill(dtJournal_ucheta_dvizheniya_tovara_na_sklade, qrJournal_ucheta_dvizheniya_tovara_na_sklade);
        }

        public void dtSprosFill()
        {
            dtFill(dtOtchet_o_sprose_i_fact_nalichii_tovarov, qrOtchet_o_sprose_i_fact_nalichii_tovarov);
        }

        public void dtSoprFill()
        {
            dtFill(dtSoprovoditelny_document, qrSoprovoditelny_document);
        }

        public void dtKomplFill()
        {
            dtFill(dtUkomplektovany_tovar, qrUkomplektovany_tovar);
        }

        public void dtShetFill()
        {
            dtFill(dtShet_facture, qrShet_facture);
        }

        public void dtPeredany_tovarFill()
        {
            dtFill(dtPeredany_tovar, qrPeredany_tovar);
        }
    }
}
