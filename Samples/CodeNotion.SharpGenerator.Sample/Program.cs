// using System;
// using System.Linq;
// using CodeNotion.SharpGenerator.EfCore;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.Extensions.Logging;
// using Vit.Backoffice.Core.Models;
// using Vit.Backoffice.Core.Models.Schede;
// using Vit.Backoffice.Core.Models.Schede.Dto;
// using Vit.Backoffice.Core.Persistence;
// using Vit.Backoffice.Core.Persistence.Factory;
// using Vit.Backoffice.Tests.SourceGeneration;
//
// DbContext ContextFactory()
// {
//     var options = new DbContextOptionsBuilder<VitBackofficeDbContext>()
//         .UseSqlServer("Data Source=.;Database=turismo2020;Trusted_Connection=True;")
//         .UseLazyLoadingProxies()
//         .LogTo(Console.WriteLine, LogLevel.Information)
//         .EnableSensitiveDataLogging()
//         .Options;
//
//     return new FullApplicationDbContext(options, null);
// }
//
// var builder = new ScenarioBuilder("../../../..", ContextFactory).BuildInterfaces("IScenario");
//
// await builder.Build("Vit.Backoffice.Tests/Scenarios", "RicercaStruttureRicettiveScenario1", ctx => ctx
//     .Set<Scheda>()
//     .Include(x => x.TestiLiberi)
//     .Where(x => x.CategoriaId == 303)
//     .Where(x => x.LocalitaId == 361)
//     .ToListAsync());