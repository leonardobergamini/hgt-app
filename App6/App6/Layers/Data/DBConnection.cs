using System;
using System.IO;
using Xamarin.Forms;
using App6.Layers.Data.Config;

namespace App6.Layers.Data
{
    public class DbConnection : IDisposable {
        public SQLite.SQLiteConnection Connection { get; }
        public DbConnection() {
            var config = DependencyService.Get<IDBConfig>();
            var caminhoArquivoBanco = Path.Combine(config.Path, "hgt.db"); 
			Connection = new SQLite.SQLiteConnection(caminhoArquivoBanco);
        }
        public void Dispose(){
            if (Connection != null) {
                Connection.Dispose();
			}
        } 
    }
}
