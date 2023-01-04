namespace questpdf_versuch

{
using QuestPDF.Infrastructure;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Drawing;
    using System.ComponentModel.Design;

    public class InvoiceModel
    {
        public int InvoiceNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }

        public Address SellerAddress { get; set; }
        public Address CustomerAddress { get; set; }

        public List<OrderItem> Items { get; set; }
        public string Comments { get; set; }
    }

    public class OrderItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }

    public class Address
    {
        public string CompanyName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public object Email { get; set; }
        public string Phone { get; set; }
    }




    public static class InvoiceDocumentDataSource
    {
        private static Random Random = new Random();

        public static InvoiceModel GetInvoiceDetails()
        {
            var items = Enumerable
                .Range(1, 8)
                .Select(i => GenerateRandomOrderItem())
                .ToList();

            return new InvoiceModel
            {
                InvoiceNumber = Random.Next(1_000, 10_000),
                IssueDate = DateTime.Now,
                DueDate = DateTime.Now + TimeSpan.FromDays(14),

                SellerAddress = GenerateRandomAddress(),
                CustomerAddress = GenerateRandomAddress(),

                Items = items,
                Comments = Placeholders.Paragraph()
            };
        }

        private static OrderItem GenerateRandomOrderItem()
        {
            return new OrderItem
            {
                Name = Placeholders.Label(),
                Price = (decimal)Math.Round(Random.NextDouble() * 100, 2),
                Quantity = Random.Next(1, 10)
            };
        }

        private static Address GenerateRandomAddress()
        {
            return new Address
            {
                CompanyName = Placeholders.Name(),
                Street = Placeholders.Label(),
                City = Placeholders.Label(),
                State = Placeholders.Label(),
                Email = Placeholders.Email(),
                Phone = Placeholders.PhoneNumber()
            };
        }
    }


    public interface IDocument
    {
        DocumentMetadata GetMetadata();
        void Compose(IDocumentContainer container);
    }




















    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(14));

                    page.Header()

                        .Text("Erklärung und ergebnisse")
                        .SemiBold().FontSize(36).FontColor(Colors.Blue.Medium);
                    page.Content()
                        .PaddingVertical(1, Unit.Centimetre)
                        .Column(x =>
                        {

                            x.Spacing(2);

                            x.Item().Text("diese datei ist der versuch mehrere daten zu schreiben");
                            x.Item().Text("hier sind placeholder (2x text und 1x bild):");
                            x.Item().Text("");
                            x.Item().Text(Placeholders.LoremIpsum());
                            x.Item().Text(Placeholders.LoremIpsum());

                            x.Item().Image(Placeholders.Image(200, 100));
                        });



                    page.Footer()
                        .AlignCenter()
                        .Text(x =>
                        {
                            x.Span("Seite ");
                            x.CurrentPageNumber();

                        });

                });
                    container.Page(page2 =>
                    {

                        page2.Size(PageSizes.A4);
                    page2.Margin(2, Unit.Centimetre);
                    page2.PageColor(Colors.White);
                    page2.DefaultTextStyle(x => x.FontSize(14));

                    page2.Header()

                        .Text("Erklärung und ergebnisse")
                        .SemiBold().FontSize(36).FontColor(Colors.Blue.Medium);
                    page2.Content()
                        .PaddingVertical(1, Unit.Centimetre)
                        .Column(x =>
                        {

                            x.Spacing(2);

                            x.Item().Text("hier steht inhalt der seite 2");
                            x.Item().Text("");
                            x.Item().Text("in der datei 02_praktischer_output.pdf ist wie der name schon sagt, der output der LOB.IT endsprechenden datei designt");
                            x.Item().Text("");
                            x.Item().Text("");

                        });



                    page2.Footer()
                        .AlignCenter()
                        .Text(x =>
                        {
                            x.Span("Seite ");
                            x.CurrentPageNumber();

                        });







                }) ;
            })
.GeneratePdf("01_zusammenfassung.pdf");



































            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Document.Create(container2 =>
            {
                container2.Page(page2 =>
                {
                    page2.Size(PageSizes.A4);
                    page2.Margin(1, Unit.Centimetre);
                    page2.PageColor(Colors.White);
                    page2.DefaultTextStyle(y => y.FontSize(12));
                    
                  
                    page2.Content()







                        .PaddingVertical(5, Unit.Millimetre)




                        .Column(y =>
                        {

                            y.Item().Background(Colors.Grey.Lighten1).Table(table =>
                             {
                                 table.ColumnsDefinition(columns =>
                                 {
                                     
                                     columns.RelativeColumn();
                                     columns.RelativeColumn();
                                     columns.RelativeColumn();
                                     columns.RelativeColumn();
                                 });
                                 table.Cell().RowSpan(2).Column(1).Image("Logo_LoB_IT.bmp");
                                 table.Cell().Row(1).Column(4).Text("Leistungskarte").FontSize(16).SemiBold();
                                 table.Cell().Row(2).Column(4).BorderBottom(1).Text("Vereinbarung");
                                 table.Cell().Row(2).Column(3).BorderBottom(1);
                                 table.Cell().Row(2).Column(2).BorderBottom(1);
                                 table.Cell().Row(2).Column(1).BorderBottom(1);

                             });
                            
    




                            
                            y.Item().AlignRight().PaddingTop(5).Text("Stand: ~datum einfügen~");
                            








                            y.Item().Background(Colors.Grey.Lighten3).Table(table =>
                            {
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.ConstantColumn(180);
                                    columns.ConstantColumn(180);
                                    columns.ConstantColumn(180);
                                    columns.RelativeColumn(2);
                                    columns.RelativeColumn(2);
                                    columns.RelativeColumn(2);
                                    
                                });


                                table.Cell().Row(1).Column(1).Border(1).Text("Projekt:\n~Projektname~");
                                table.Cell().Row(2).Column(1).Border(1).Text("Beschäftigte/r:\n~Name~");
                                table.Cell().Row(3).Column(1).Border(1).Text("Leitung:\n~Name~");

                                table.Cell().Row(1).Column(2).Border(1).Text("Gruppe:\n~Name~");
                                table.Cell().Row(2).Column(2).Border(1).Text("Personalnummer:\n~Nummer~");
                                table.Cell().Row(3).Column(2).Border(1).Text("Leistungsergebnis:\n~ergebnis~");

                                table.Cell().Row(1).Column(3).Border(1).Text("Beurteilungszeitraum:\n~Datum~");
                                table.Cell().Row(2).Column(3).Border(1).Text("Vereinbart am:\n~Datum~");
                                table.Cell().Row(3).Column(3).Border(1).Text("Bewertung abgeschlossen am:\n~Datum~");
                            });

                            y.Item().PaddingBottom(5).Table(table =>
                            {
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.RelativeColumn();
                                    columns.RelativeColumn();
                                    columns.RelativeColumn();
                                    columns.RelativeColumn();
                                });
                                
                                table.Cell().Row(1).Column(1).PaddingTop(10).Text("Zielvereinbarung").FontSize(14).SemiBold();
                                table.Cell().Row(1).Column(4).PaddingTop(10).Text("Gewichtung: ~XX%~").FontSize(14).SemiBold();

                            });


                            y.Item().Table(table =>
                            {
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.ConstantColumn(75);
                                    columns.ConstantColumn(98);
                                    columns.ConstantColumn(75);
                                    columns.ConstantColumn(75);
                                    columns.ConstantColumn(72);
                                    columns.ConstantColumn(72);
                                    columns.ConstantColumn(72);
                                    columns.RelativeColumn(2);
                                    columns.RelativeColumn(2);
                                    columns.RelativeColumn(2);
                                    columns.RelativeColumn(2);
                                    columns.RelativeColumn(2);
                                    columns.RelativeColumn(2);
                                    columns.RelativeColumn(2);

                                });


                                table.Cell().Row(1).Column(1).Border(1).Background(Colors.Grey.Lighten3).Text("Bereich ");
                                table.Cell().Row(2).Column(1).Border(1).Text("~Teamziel~\n ");
                                table.Cell().Row(3).Column(1).Border(1).Text("~Teamziel~\n ");

                                table.Cell().Row(1).Column(2).Border(1).Background(Colors.Grey.Lighten3).Text("Ziel ");
                                table.Cell().Row(2).Column(2).Border(1).Text("");
                                table.Cell().Row(3).Column(2).Border(1).Text(" ");

                                table.Cell().Row(1).Column(3).Border(1).Background(Colors.Grey.Lighten3).Text("Gewichtung ");
                                table.Cell().Row(2).Column(3).Border(1).Text(" ");
                                table.Cell().Row(3).Column(3).Border(1).Text(" ");

                                table.Cell().Row(1).Column(4).Border(1).Background(Colors.Grey.Lighten3).Text("Messgröße ");
                                table.Cell().Row(2).Column(4).Border(1).Text(" ");
                                table.Cell().Row(3).Column(4).Border(1).Text(" ");

                                table.Cell().Row(1).Column(5).Border(1).Background(Colors.Grey.Lighten3).Text("Ziel(100%) ");
                                table.Cell().Row(2).Column(5).Border(1).Text(" ");
                                table.Cell().Row(3).Column(5).Border(1).Text(" ");

                                table.Cell().Row(1).Column(6).Border(1).Background(Colors.Grey.Lighten3).Text("Ergebnis ");
                                table.Cell().Row(2).Column(6).Border(1).Text(" ");
                                table.Cell().Row(3).Column(6).Border(1).Text(" ");

                                table.Cell().Row(1).Column(7).Border(1).Background(Colors.Grey.Lighten3).Text("Summe ");
                                table.Cell().Row(2).Column(7).Border(1).Text(" ");
                                table.Cell().Row(3).Column(7).Border(1).Text(" ");


                            });


                            y.Item().Table(table =>
                            {
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.ConstantColumn(467);
                                    columns.ConstantColumn(72);
                                    columns.RelativeColumn(2);
                                    columns.RelativeColumn(2);


                                });


                                table.Cell().Row(1).Column(1).Border(1).AlignRight().Text("Zwichenergebniss ");
                                table.Cell().Row(2).Column(1).Border(1).AlignRight().Text("Summe Leistungesbarungen (50%) ").SemiBold();
                                

                                table.Cell().Row(1).Column(2).Border(1).Text(" ");
                                table.Cell().Row(2).Column(2).Border(1).Text(" ");
                                


                            });




                            y.Item().PaddingBottom(5).Table(table =>
                            {
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.RelativeColumn();
                                    columns.RelativeColumn();
                                    columns.RelativeColumn();
                                    columns.RelativeColumn();
                                });

                                table.Cell().Row(1).Column(1).PaddingTop(10).Text("Leistungsbewertung").FontSize(14).SemiBold();
                                table.Cell().Row(1).Column(4).PaddingTop(10).Text("Gewichtung: ~XX%~").FontSize(14).SemiBold();

                            });


                            y.Item().Table(table =>
                            {
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.ConstantColumn(173);
                                    columns.ConstantColumn(150);
                                    columns.ConstantColumn(144);
                                    columns.ConstantColumn(72);

                                    columns.RelativeColumn(2);
                                    columns.RelativeColumn(2);
                                    columns.RelativeColumn(2);
                                    columns.RelativeColumn(2);



                                });


                                table.Cell().Row(1).Column(1).Border(1).Background(Colors.Grey.Lighten3).Text("Leistungskriterium ");
                                table.Cell().Row(2).Column(1).Border(1).Text(" ");
                                table.Cell().Row(3).Column(1).Border(1).Text(" ");
                                table.Cell().Row(4).Column(1).Border(1).Text(" ");
                                table.Cell().Row(5).Column(1).Border(1).Text(" ");


                                table.Cell().Row(1).Column(2).Border(1).Background(Colors.Grey.Lighten3).Text("Gewichtung ");
                                table.Cell().Row(2).Column(2).Border(1).Text(" ");
                                table.Cell().Row(3).Column(2).Border(1).Text(" ");
                                table.Cell().Row(4).Column(2).Border(1).Text(" ");
                                table.Cell().Row(5).Column(2).Border(1).Text(" ");


                                table.Cell().Row(1).Column(3).Border(1).Background(Colors.Grey.Lighten3).Text("Ergebnis ");
                                table.Cell().Row(2).Column(3).Border(1).Text(" ");
                                table.Cell().Row(3).Column(3).Border(1).Text(" ");
                                table.Cell().Row(4).Column(3).Border(1).Text(" ");
                                table.Cell().Row(5).Column(3).Border(1).Text(" ");


                                table.Cell().Row(1).Column(4).Border(1).Background(Colors.Grey.Lighten3).Text("Summe ");
                                table.Cell().Row(2).Column(4).Border(1).Text(" ");
                                table.Cell().Row(3).Column(4).Border(1).Text(" ");
                                table.Cell().Row(4).Column(4).Border(1).Text(" ");
                                table.Cell().Row(5).Column(4).Border(1).Text(" ");





                            });


                            y.Item().Table(table =>
                            {
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.ConstantColumn(467);
                                    columns.ConstantColumn(72);
                                    columns.RelativeColumn(2);
                                    columns.RelativeColumn(2);


                                });


                                table.Cell().Row(1).Column(1).Border(1).AlignRight().Text("Zwichenergebniss ");
                                table.Cell().Row(2).Column(1).Border(1).AlignRight().Text("Summe Leistungesbarungen (50%) ").SemiBold();


                                table.Cell().Row(1).Column(2).Border(1).Text(" ");
                                table.Cell().Row(2).Column(2).Border(1).Text(" ");



                            });











                            //plan: tabelle mit 2 zeilen und 7 spalten
                            // obere zeile bleibt leer
                            //obere zeile bekommt in1,3,5,7 eine horizontallinie
                            // 2,4,6 bekommen eine breite von 2-10
                            // untere zeile bekommt inhalte ebefalls in dieser




                            // aufteilung in 2 tabellen
                            //zweite tabelle gleiches konzept andere anzahl
                            //2 reihen 4 spalten
                            //1,2,3 endsprechen der tabelle von oben
                            // 4 bekommt ein leeres feld mit der restlichen breite
                            //eventuell musss kene 4te erstellt werden










                            y.Item().PaddingTop(55).Table(table =>
                            {
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.ConstantColumn(57);
                                    columns.ConstantColumn(16);
                                    columns.ConstantColumn(177);
                                    columns.ConstantColumn(16);
                                    columns.ConstantColumn(57);
                                    columns.ConstantColumn(16);
                                    columns.ConstantColumn(177);
                                });

                                table.Cell().Row(1).Column(1).BorderBottom(1);
                                table.Cell().Row(2).Column(1).Text("Datum");

                                table.Cell().Row(1).Column(2);
                                table.Cell().Row(2).Column(2);

                                table.Cell().Row(1).Column(3).BorderBottom(1);
                                table.Cell().Row(2).Column(3).Text("Unterschrifft Führungskraft");

                                table.Cell().Row(1).Column(4);
                                table.Cell().Row(2).Column(4);

                                table.Cell().Row(1).Column(5).BorderBottom(1);
                                table.Cell().Row(2).Column(5).Text("Datum");

                                table.Cell().Row(1).Column(6);
                                table.Cell().Row(2).Column(6);

                                table.Cell().Row(1).Column(7).BorderBottom(1);
                                table.Cell().Row(2).Column(7).Text("Unterschrift Beschäftigter");

                            });



                            y.Item().PaddingTop(55).Table(table =>
                            {
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.ConstantColumn(57);
                                    columns.ConstantColumn(16);
                                    columns.ConstantColumn(177);
                                    
                                });

                                table.Cell().Row(1).Column(1).BorderBottom(1);
                                table.Cell().Row(2).Column(1).Text("Datum");

                                table.Cell().Row(1).Column(2);
                                table.Cell().Row(2).Column(2);

                                table.Cell().Row(1).Column(3).BorderBottom(1);
                                table.Cell().Row(2).Column(3).Text("Unterschrifft nächsthöhere/r Vorgesetzte/r");

                            });










;



































                        });





                    page2.Footer().Height(50).Background(Colors.Grey.Lighten1)
                        .AlignCenter()
                        .Text(x =>
                        {
                            x.Span("Seite ");
                            x.CurrentPageNumber();

                        });
                });


            })
.GeneratePdf("02_praktischer_output.pdf");

        }
    }
}