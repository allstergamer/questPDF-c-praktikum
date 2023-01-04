namespace questpdf_versuch

{
using QuestPDF.Infrastructure;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Drawing;







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
                    page2.Margin(2, Unit.Centimetre);
                    page2.PageColor(Colors.Grey.Lighten3);
                    page2.DefaultTextStyle(y => y.FontSize(14));
                    
                    page2.Header().Height(100)
                        .Text("Rechnung pre-design")
                        .SemiBold().FontSize(36).FontColor(Colors.Blue.Medium);
                    page2.Content()







                        .PaddingVertical(1, Unit.Centimetre)
                        .Column(y =>
                        {
                            y.Item().BorderHorizontal(1);
                            y.Spacing(14);
                            y.Item().AlignRight().Text("Leistungskarte");
                            y.Item().AlignRight().Text("Vereinbarung");
                            y.Item().BorderHorizontal(1);
                            y.Item().Text(Placeholders.LoremIpsum());
                            y.Item().Text("hier könnte ihre werbung stehen");
                            y.Item().Image(Placeholders.Image(200, 100));
                            y.Item().Text("");







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