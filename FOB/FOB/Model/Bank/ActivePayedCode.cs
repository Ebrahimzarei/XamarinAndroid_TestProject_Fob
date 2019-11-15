using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;

namespace FOB.Model.Bank
{
    public class ActivePayedCode
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public string Payed_Code { get; set; }
        public string Date { get; set; }
    }
    public class DbFob
    {
        readonly string dbConnectionStr =
            System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "/DBFob.db3";
        SQLiteConnection db;
        public DbFob()
        {
            db = new SQLiteConnection(dbConnectionStr);
            db.CreateTable<ActivePayedCode>();
            db.CreateTable<StatuseVerify>();
        }
        public int StatuseVerifyInsert(StatuseVerify models)
        {
            db.Insert(models);
            return models.Id;
        }
        public StatuseVerify StatuseVerifyFind(int Id)
        {
            return db.Find<StatuseVerify>(Id);
        }
        public List<StatuseVerify> StatuseVerifyGetAll(string sortField = "Id")
        {
            return db.Query<StatuseVerify>("SELECT * FROM StatuseVerify ORDER BY " + sortField);
        }




        public int ActivePayedInsert(ActivePayedCode models)
        {
            db.Insert(models);
            return models.Id;
        }
        public void ActivePayedDelete(int Id)
        {
            db.Delete<ActivePayedCode>(Id);
        }
        public ActivePayedCode ActivePayCodeFind(int Id)
        {
            return db.Find<ActivePayedCode>(Id);
        }
        public List<ActivePayedCode> ActivePayedGetAll(string sortField = "Id")
        {
            return db.Query<ActivePayedCode>("SELECT * FROM ActivePayedCode ORDER BY " + sortField);
        }
    }
}