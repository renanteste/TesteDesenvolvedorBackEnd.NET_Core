using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TesteDesenvolvedorBackEnd.NET_Core.Models;

namespace TesteDesenvolvedorBackEnd.NET_Core.Data
{
    public class ContextoCliente : DbContext
    {   
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Password=70432;Persist Security Info=True;User ID=dbaspd;Initial Catalog=ClienteDotNet; Data Source=10.61.238.89");
        }
    }
}

//<connectionStrings>
//    <add name = "bdcorpSql" connectionString="data source=10.61.238.89;user id=dbaspd;password=70432;MultipleActiveResultSets=True"/>
//    <add name = "PRODUCAOSQLSGP" connectionString="data source=10.57.8.19,65535;user id=W3$SGP;password=SG@P2019@;MultipleActiveResultSets=True;"/>
//    <add name = "PRODUCAOSQL" connectionString="data source=10.57.8.19,65535;user id=w3$rh;password=!w3$rh@ISTCDP-01!;MultipleActiveResultSets=True;" />
//    <add name = "PRODUCAOEntities" connectionString="metadata=res://*/Models.BD_PRODUCAO.csdl|res://*/Models.BD_PRODUCAO.ssdl|res://*/Models.BD_PRODUCAO.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=10.57.8.19,65535;initial catalog=BDCORP;persist security info=True;user id=w3$rh;password=!w3$rh@ISTCDP-01!;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
//    <add name = "AlmanaquesEntities" connectionString="metadata=res://*/Models.BD_Almanaques.csdl|res://*/Models.BD_Almanaques.ssdl|res://*/Models.BD_Almanaques.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=10.61.238.89;initial catalog=Almanaques;user id=dbaspd;password=70432;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
//    <add name = "bdcorpEntities" connectionString="metadata=res://*/Models.bdcorpEntities.csdl|res://*/Models.bdcorpEntities.ssdl|res://*/Models.bdcorpEntities.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=10.61.238.89;initial catalog=bdcorp;user id=dbaspd;password=70432;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
//    <add name = "conexaoMongoDB" connectionString="mongodb://10.61.17.22:27017"/>
//    <add name = "conexaoMongoDBRegras" connectionString="mongodb://10.57.8.51:27017"/>
//    <add name = "conexaoMongoAverbacao" connectionString="mongodb://10.57.8.49:27018"/>
//    <add name = "conexaoMongoBdged" connectionString="mongodb://10.57.8.49:27017"/>
//    <add name = "conexaoMongoTools" connectionString="mongodb://10.57.8.58:1880"/>
//    <add name = "conexaoValidacaoRegra" connectionString="mongodb://10.56.195.23:27017"/>
//    <add name = "conexaoMongoDicionarioDados" connectionString="mongodb://10.57.8.49:27017"/>
//    <add name = "conexaoMongoRptBd" connectionString="mongodb://10.56.195.25:27018"/>
//  </connectionStrings>