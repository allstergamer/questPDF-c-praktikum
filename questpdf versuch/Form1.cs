namespace questpdf_versuch

{
using QuestPDF.Infrastructure;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Drawing;
    using System.ComponentModel.Design;













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
                    page.DefaultTextStyle(x => x.FontSize(12));

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
                            x.Span(" von ");
                            x.TotalPages();

                        });

                });
                    container.Page(page2 =>
                    {

                        page2.Size(PageSizes.A4);
                    page2.Margin(1, Unit.Centimetre);
                    page2.PageColor(Colors.White);
                    page2.DefaultTextStyle(x => x.FontSize(14));

                    page2.Header().Text("Erklärung und ergebnisse").SemiBold().FontSize(36).FontColor(Colors.Blue.Medium);
                    page2.Content()
                        .PaddingVertical(1, Unit.Centimetre)
                        .Column(x =>
                        {
                            x.Spacing(2);

                            x.Item().Text("hier steht inhalt der seite 2");
                            x.Item().Text("");
                            x.Item().Text("in der datei 02_praktischer_output.pdf ist wie der name schon sagt, der output der LOB.IT endsprechenden datei designt");
                            x.Item().Text("");
                            x.Item().Text("hier folgt die vergleiche der inhalte der PDF's");
                            x.Item().Text("zuerst folgt immer die bezeichnung worum es geht, danach die darstellung dieser und unten drunter steht welche datein diese beinhalten");
                            x.Item().Text("");
                            x.Item().Text("her stehen nur die datein imhochformat");
                            x.Item().Text("");
                            x.Item().Text("folgende datein sind nicht hier auffindbar");
                            x.Item().Text("Teamzieluebersicht, Projektuebersicht, Personaluebersicht, Bewertungsbogen");
                            x.Item().Text("");
                            x.Item().Text("Header 2 zeilen");


                            //header mit 2 zeilen
                            x.Item().Background(Colors.Grey.Lighten1).Table(table =>
                            {
                                table.ColumnsDefinition(columns =>
                                {

                                    columns.RelativeColumn();
                                    columns.RelativeColumn();
                                    columns.RelativeColumn();
                                    columns.RelativeColumn();
                                });
                                table.Cell().RowSpan(2).Column(1).Image("Logo_LoB_IT.bmp");
                                table.Cell().Row(1).Column(4).AlignRight().Text("Leistungskarte ").FontSize(16).SemiBold();
                                table.Cell().Row(2).Column(4).AlignRight().Text("Vereinbarung ");
                                table.Cell().Row(2).Column(3);
                                table.Cell().Row(2).Column(2);
                                table.Cell().Row(2).Column(1);

                            });
                            x.Item().Text("");
                            x.Item().Text(" Leistungskarte_Barcode, Leistungskarte_mit_Vereinbarungen, Leistungskarte_mit_Vereinbarungen_mit_Erlaeuterungen, Leistungskarte_mit_Zwischenbereicht_mit_Erlaeuterungen, Zielvereinbarungsuebersicht");

                            x.Item().Text("");
                            x.Item().Text("");
                            x.Item().Text("");
                            x.Item().Text("");
                            x.Item().Text("");
                            x.Item().Text("");

                            x.Item().Text("Header 1 zeile");

                            //header mit 1 zeile
                            x.Item().Background(Colors.Grey.Lighten1).Table(table =>
                            {
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.ConstantColumn(200);
                                    columns.ConstantColumn(338);
                                    
                                });
                                table.Cell().Column(1).MaxWidth(120).Image("Logo_LoB_IT.bmp");
                                table.Cell().Row(1).Column(2).PaddingTop(8).AlignRight().Text("Auszahlungsergebnis ").FontSize(14).SemiBold();
                                
                            });

                            x.Item().Text("");
                            x.Item().Text("Auszahlungsbericht, Projektstatistik");

                            x.Item().Text("");
                            x.Item().Text("");
                            x.Item().Text("Projekt tabelle");


                            //Projekttabelle
                            x.Item().Background(Colors.Grey.Lighten3).Table(table =>
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


                                table.Cell().Row(1).Column(1).Border(1).Text(" Projekt:\n~Projektname~");
                                table.Cell().Row(2).Column(1).Border(1).Text(" Beschäftigte/r:\n~Name~");
                                table.Cell().Row(3).Column(1).Border(1).Text(" Leitung:\n~Name~");

                                table.Cell().Row(1).Column(2).Border(1).Text(" Gruppe:\n~Name~");
                                table.Cell().Row(2).Column(2).Border(1).Text(" Personalnummer:\n~Nummer~");
                                table.Cell().Row(3).Column(2).Border(1).Text(" Leistungsergebnis:\n~ergebnis~");

                                table.Cell().Row(1).Column(3).Border(1).Text(" Beurteilungszeitraum:\n~Datum~");
                                table.Cell().Row(2).Column(3).Border(1).Text(" Vereinbart am:\n~Datum~");
                                table.Cell().Row(3).Column(3).Border(1).Text(" Bewertung abgeschlossen am:\n~Datum~");
                            });



                            x.Item().Text("");
                            x.Item().Text("Auszahlungsbericht, Leistungskarte_Barcode, Leistungskarte_mit_Vereinbarungen, Leistungskarte_mit_Vereinbarungen_mit_Erlaeuterungen, Leistungskarte_mit_Zwischenbereicht_mit_Erlaeuterungen");





                            x.Item().Text("Zielvereinbarungstabelle");


                            //zielvereinbarung + tabelle
                            x.Item().Table(table =>
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
                            x.Item().Table(table =>
                            {
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.ConstantColumn(75);
                                    columns.ConstantColumn(98);
                                    columns.ConstantColumn(82);
                                    columns.ConstantColumn(75);
                                    columns.ConstantColumn(72);
                                    columns.ConstantColumn(65);
                                    columns.ConstantColumn(72);
                                    columns.RelativeColumn(2);
                                    columns.RelativeColumn(2);
                                    columns.RelativeColumn(2);
                                    columns.RelativeColumn(2);
                                    columns.RelativeColumn(2);
                                    columns.RelativeColumn(2);
                                    columns.RelativeColumn(2);

                                });

                                table.Cell().Row(1).Column(1).Border(1).Background(Colors.Grey.Lighten3).Text(" Bereich ");
                                table.Cell().Row(2).Column(1).Border(1).Text("~Teamziel~\n ");
                                table.Cell().Row(3).Column(1).Border(1).Text("~Teamziel~\n ");

                                table.Cell().Row(1).Column(2).Border(1).Background(Colors.Grey.Lighten3).Text(" Ziel ");
                                table.Cell().Row(2).Column(2).Border(1).Text("");
                                table.Cell().Row(3).Column(2).Border(1).Text(" ");

                                table.Cell().Row(1).Column(3).Border(1).Background(Colors.Grey.Lighten3).Text(" Gewichtung ");
                                table.Cell().Row(2).Column(3).Border(1).Text(" ");
                                table.Cell().Row(3).Column(3).Border(1).Text(" ");

                                table.Cell().Row(1).Column(4).Border(1).Background(Colors.Grey.Lighten3).Text(" Messgröße ");
                                table.Cell().Row(2).Column(4).Border(1).Text(" ");
                                table.Cell().Row(3).Column(4).Border(1).Text(" ");

                                table.Cell().Row(1).Column(5).Border(1).Background(Colors.Grey.Lighten3).Text(" Ziel(100%) ");
                                table.Cell().Row(2).Column(5).Border(1).Text(" ");
                                table.Cell().Row(3).Column(5).Border(1).Text(" ");

                                table.Cell().Row(1).Column(6).Border(1).Background(Colors.Grey.Lighten3).Text(" Ergebnis ");
                                table.Cell().Row(2).Column(6).Border(1).Text(" ");
                                table.Cell().Row(3).Column(6).Border(1).Text(" ");

                                table.Cell().Row(1).Column(7).Border(1).Background(Colors.Grey.Lighten3).Text(" Summe ");
                                table.Cell().Row(2).Column(7).Border(1).Text(" ");
                                table.Cell().Row(3).Column(7).Border(1).Text(" ");


                                table.Cell().Row(4).ColumnSpan(6).Border(1).AlignRight().Text("Zwichenergebniss ");
                                table.Cell().Row(5).ColumnSpan(6).Border(1).AlignRight().Text("Summe Leistungesbarungen (50%) ").SemiBold();

                                table.Cell().Row(4).Column(7).Border(1).Text(" ");
                                table.Cell().Row(5).Column(7).Border(1).Text(" ");


                            });

                            x.Item().Text("");
                            x.Item().Text("Leistungskarte_Barcode, Leistungskarte_mit_Vereinbarungen, Leistungskarte_mit_Vereinbarungen_mit_Erlaeuterungen, Leistungskarte_mit_Zwischenbereicht_mit_Erlaeuterungen");



                            // Leistungsbewertunf + Tabelle
                            x.Item().Table(table =>
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
                            x.Item().Table(table =>
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

                                table.Cell().Row(1).Column(1).Border(1).Background(Colors.Grey.Lighten3).Text(" Leistungskriterium ");
                                table.Cell().Row(2).Column(1).Border(1).Text(" ");
                                table.Cell().Row(3).Column(1).Border(1).Text(" ");
                                table.Cell().Row(4).Column(1).Border(1).Text(" ");
                                table.Cell().Row(5).Column(1).Border(1).Text(" ");


                                table.Cell().Row(1).Column(2).Border(1).Background(Colors.Grey.Lighten3).Text(" Gewichtung ");
                                table.Cell().Row(2).Column(2).Border(1).Text(" ");
                                table.Cell().Row(3).Column(2).Border(1).Text(" ");
                                table.Cell().Row(4).Column(2).Border(1).Text(" ");
                                table.Cell().Row(5).Column(2).Border(1).Text(" ");


                                table.Cell().Row(1).Column(3).Border(1).Background(Colors.Grey.Lighten3).Text(" Ergebnis ");
                                table.Cell().Row(2).Column(3).Border(1).Text(" ");
                                table.Cell().Row(3).Column(3).Border(1).Text(" ");
                                table.Cell().Row(4).Column(3).Border(1).Text(" ");
                                table.Cell().Row(5).Column(3).Border(1).Text(" ");


                                table.Cell().Row(1).Column(4).Border(1).Background(Colors.Grey.Lighten3).Text(" Summe ");
                                table.Cell().Row(2).Column(4).Border(1).Text(" ");
                                table.Cell().Row(3).Column(4).Border(1).Text(" ");
                                table.Cell().Row(4).Column(4).Border(1).Text(" ");
                                table.Cell().Row(5).Column(4).Border(1).Text(" ");


                                table.Cell().Row(6).ColumnSpan(3).Border(1).AlignRight().Text("Zwichenergebniss ");
                                table.Cell().Row(7).ColumnSpan(3).Border(1).AlignRight().Text("Summe Leistungesbarungen (50%) ").SemiBold();

                                table.Cell().Row(6).Column(4).Border(1).Text(" ");
                                table.Cell().Row(7).Column(4).Border(1).Text(" ");

                            });

                            x.Item().Text("Leistungskarte_Barcode, Leistungskarte_mit_Vereinbarungen, Leistungskarte_mit_Vereinbarungen_mit_Erlaeuterungen, Leistungskarte_mit_Zwischenbereicht_mit_Erlaeuterungen");




                            x.Item().Text("Unterschriftenfeld");
                            //4 unterschriften nebeneinander
                            x.Item().PaddingTop(55).Table(table =>
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
                                table.Cell().Row(2).Column(1).Text(" Datum");

                                table.Cell().Row(1).Column(2);
                                table.Cell().Row(2).Column(2);

                                table.Cell().Row(1).Column(3).BorderBottom(1);
                                table.Cell().Row(2).Column(3).Text(" Unterschrifft Führungskraft");

                                table.Cell().Row(1).Column(4);
                                table.Cell().Row(2).Column(4);

                                table.Cell().Row(1).Column(5).BorderBottom(1);
                                table.Cell().Row(2).Column(5).Text(" Datum");

                                table.Cell().Row(1).Column(6);
                                table.Cell().Row(2).Column(6);

                                table.Cell().Row(1).Column(7).BorderBottom(1);
                                table.Cell().Row(2).Column(7).Text(" Unterschrift Beschäftigter");

                            });
                            //2 unterschriften neben einander
                            x.Item().PaddingTop(55).Table(table =>
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
                            x.Item().Text("Leistungskarte_Barcode, Leistungskarte_mit_Vereinbarungen, Leistungskarte_mit_Vereinbarungen_mit_Erlaeuterungen, Leistungskarte_mit_Zwischenbereicht_mit_Erlaeuterungen");
                            x.Item().Text("");
                            x.Item().Text("");


                            //Projektstatistik
                            x.Item().Text("Projektstatistik");
                            x.Item().Background(Colors.Grey.Lighten3).Table(table =>
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


                                table.Cell().Row(1).ColumnSpan(2).Border(1).Text(" Projektstatistik: ~Projektname~");
                                table.Cell().Row(2).Column(1).Border(1).Text(" Volumen:\n ~Volumen~");
                                table.Cell().Row(3).Column(1).Border(1).Text(" Normale Berechnung:\n ~wert~");

                                
                                table.Cell().Row(2).Column(2).Border(1).Text(" Ausgeschüttet:\n ~Wert~");
                                table.Cell().Row(3).Column(2).Border(1).Text(" Durchschnitt:\n ~Durchschnitt~");

                                table.Cell().Row(1).Column(3).Border(1).Text(" Anzahl Besschäftigte: ~Anzahl~");
                                table.Cell().Row(2).Column(3).Border(1).Text(" Restbetrag:\n ~Betrag~");
                                table.Cell().Row(3).Column(3).Border(1).Text(" Ausschluss:\n ~Wert~");
                            });

                            x.Item().PaddingTop(5).Text("Projektstatistik");




                            //Berechnungsmethode
                            x.Item().PaddingTop(10).Text("Berechnungsmethode");
                            x.Item().Background(Colors.Grey.Lighten3).Table(table =>
                            {
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.ConstantColumn(190);
                                    columns.ConstantColumn(350);
                                    
                                    columns.RelativeColumn(2);
                                    columns.RelativeColumn();

                                });


                                table.Cell().Row(1).Column(1).Border(1).Text(" Feststehender Anteil am Leistungsentgelt (Stammdaten- Assistent S. 3) ");
                                table.Cell().Row(1).Column(2).Border(1).Text(" ~Inhalt~");

                                table.Cell().Row(2).Column(1).Border(1).Text(" Feste Verteilung nach Zielerreichung:");
                                table.Cell().Row(2).Column(2).Border(1).Text(" ~Inhalt~");

                                table.Cell().Row(3).Column(1).Border(1).Text(" Entgelt für Leistungskarte:");
                                table.Cell().Row(3).Column(2).Border(1).Text(" ~Inhalt~");

                                table.Cell().Row(4).Column(1).Border(1).Text(" Berechnung der Deckelung:");
                                table.Cell().Row(4).Column(2).Border(1).Text(" ~Inhalt~");

                                table.Cell().Row(5).Column(1).Border(1).Text(" Abschlussrechnung:");
                                table.Cell().Row(5).Column(2).Border(1).Text(" ~Inhalt~");



                            });

                            x.Item().PaddingTop(5).Text("Projektstatistik");




                            //Auszahlungsbetrag
                            x.Item().PaddingTop(15).Text(" Auszahlungsbetrag:");

                            x.Item().Background(Colors.Grey.Lighten3).Table(table =>
                            {
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.ConstantColumn(190);
                                    columns.ConstantColumn(350);

                                    columns.RelativeColumn(2);
                                    columns.RelativeColumn();

                                });


                                table.Cell().Row(1).Column(1).BorderLeft(1).BorderTop(1).BorderBottom(1).Text(" Auszahlungsbetrag : ").SemiBold().FontSize(16);
                                table.Cell().Row(1).Column(2).BorderRight(1).BorderTop(1).BorderBottom(1).AlignRight().Text(" ~summe~ € ").SemiBold().FontSize(16);

                                
                                table.Cell().Row(2).ColumnSpan(2).Border(1).AlignRight().Hyperlink("https://www.kommSolutions.de").Text(" kommSolutions ").SemiBold().FontSize(16);





                            });



                            x.Item().PaddingTop(5).Text("Projektstatistik");




















                        });


                        page2.Footer()
                        .AlignCenter()
                        .Text(x =>
                        {
                            x.Span("Seite ");
                            x.CurrentPageNumber();
                            x.Span(" von ");
                            x.TotalPages();

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
                    page2.Content().PaddingVertical(5, Unit.Millimetre)

                        .Column(y =>
                        {
                            //header
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
                                 table.Cell().Row(1).Column(4).AlignRight().Text("Leistungskarte ").FontSize(16).SemiBold();
                                 table.Cell().Row(2).Column(4).AlignRight().Text("Vereinbarung ");

                             });
                            
                            //datum
                            y.Item().AlignRight().PaddingTop(5).Text("Stand: ~datum einfügen~");
                            

                            //Projekttabelle
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

                                table.Cell().Row(1).Column(1).Border(1).Text(" Projekt:\n~Projektname~");
                                table.Cell().Row(2).Column(1).Border(1).Text(" Beschäftigte/r:\n~Name~");
                                table.Cell().Row(3).Column(1).Border(1).Text(" Leitung:\n~Name~");

                                table.Cell().Row(1).Column(2).Border(1).Text(" Gruppe:\n~Name~");
                                table.Cell().Row(2).Column(2).Border(1).Text(" Personalnummer:\n~Nummer~");
                                table.Cell().Row(3).Column(2).Border(1).Text(" Leistungsergebnis:\n~ergebnis~");

                                table.Cell().Row(1).Column(3).Border(1).Text(" Beurteilungszeitraum:\n~Datum~");
                                table.Cell().Row(2).Column(3).Border(1).Text(" Vereinbart am:\n~Datum~");
                                table.Cell().Row(3).Column(3).Border(1).Text(" Bewertung abgeschlossen am:\n~Datum~");
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

                                table.Cell().Row(1).Column(1).Border(1).Background(Colors.Grey.Lighten3).Text(" Bereich ");
                                table.Cell().Row(2).Column(1).Border(1).Text("~Teamziel~\n ");
                                table.Cell().Row(3).Column(1).Border(1).Text("~Teamziel~\n ");

                                table.Cell().Row(1).Column(2).Border(1).Background(Colors.Grey.Lighten3).Text(" Ziel ");
                                table.Cell().Row(2).Column(2).Border(1).Text("");
                                table.Cell().Row(3).Column(2).Border(1).Text(" ");

                                table.Cell().Row(1).Column(3).Border(1).Background(Colors.Grey.Lighten3).Text(" Gewichtung ");
                                table.Cell().Row(2).Column(3).Border(1).Text(" ");
                                table.Cell().Row(3).Column(3).Border(1).Text(" ");

                                table.Cell().Row(1).Column(4).Border(1).Background(Colors.Grey.Lighten3).Text(" Messgröße ");
                                table.Cell().Row(2).Column(4).Border(1).Text(" ");
                                table.Cell().Row(3).Column(4).Border(1).Text(" ");

                                table.Cell().Row(1).Column(5).Border(1).Background(Colors.Grey.Lighten3).Text(" Ziel(100%) ");
                                table.Cell().Row(2).Column(5).Border(1).Text(" ");
                                table.Cell().Row(3).Column(5).Border(1).Text(" ");

                                table.Cell().Row(1).Column(6).Border(1).Background(Colors.Grey.Lighten3).Text(" Ergebnis ");
                                table.Cell().Row(2).Column(6).Border(1).Text(" ");
                                table.Cell().Row(3).Column(6).Border(1).Text(" ");

                                table.Cell().Row(1).Column(7).Border(1).Background(Colors.Grey.Lighten3).Text(" Summe ");
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

                                table.Cell().Row(1).Column(1).Border(1).Background(Colors.Grey.Lighten3).Text(" Leistungskriterium ");
                                table.Cell().Row(2).Column(1).Border(1).Text(" ");
                                table.Cell().Row(3).Column(1).Border(1).Text(" ");
                                table.Cell().Row(4).Column(1).Border(1).Text(" ");
                                table.Cell().Row(5).Column(1).Border(1).Text(" ");


                                table.Cell().Row(1).Column(2).Border(1).Background(Colors.Grey.Lighten3).Text(" Gewichtung ");
                                table.Cell().Row(2).Column(2).Border(1).Text(" ");
                                table.Cell().Row(3).Column(2).Border(1).Text(" ");
                                table.Cell().Row(4).Column(2).Border(1).Text(" ");
                                table.Cell().Row(5).Column(2).Border(1).Text(" ");


                                table.Cell().Row(1).Column(3).Border(1).Background(Colors.Grey.Lighten3).Text(" Ergebnis ");
                                table.Cell().Row(2).Column(3).Border(1).Text(" ");
                                table.Cell().Row(3).Column(3).Border(1).Text(" ");
                                table.Cell().Row(4).Column(3).Border(1).Text(" ");
                                table.Cell().Row(5).Column(3).Border(1).Text(" ");


                                table.Cell().Row(1).Column(4).Border(1).Background(Colors.Grey.Lighten3).Text(" Summe ");
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
                                table.Cell().Row(2).Column(1).Text(" Datum");

                                table.Cell().Row(1).Column(2);
                                table.Cell().Row(2).Column(2);

                                table.Cell().Row(1).Column(3).BorderBottom(1);
                                table.Cell().Row(2).Column(3).Text(" Unterschrifft Führungskraft");

                                table.Cell().Row(1).Column(4);
                                table.Cell().Row(2).Column(4);

                                table.Cell().Row(1).Column(5).BorderBottom(1);
                                table.Cell().Row(2).Column(5).Text(" Datum");

                                table.Cell().Row(1).Column(6);
                                table.Cell().Row(2).Column(6);

                                table.Cell().Row(1).Column(7).BorderBottom(1);
                                table.Cell().Row(2).Column(7).Text(" Unterschrift Beschäftigter");

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

                        });

                    page2.Footer().Height(50).Background(Colors.Grey.Lighten1)
                        .AlignCenter()
                        .PaddingTop(15)
                        .Text(x =>
                        {
                            x.Span("Seite ");
                            x.CurrentPageNumber();
                            x.Span(" von ");
                            x.TotalPages();

                        });
                });


            })
.GeneratePdf("02_praktischer_output.pdf");

        }

        private void button3_Click(object sender, EventArgs e)
        {


            Document.Create(container3 =>
            {
                container3.Page(page =>
            {

                page.Size(PageSizes.A3.Landscape());
                page.Margin(2, Unit.Centimetre);
                page.PageColor(Colors.White);
                page.DefaultTextStyle(x => x.FontSize(12));

                page.Header()

                    .Text("Erklärung und ergebnisse")
                    .SemiBold().FontSize(36).FontColor(Colors.Blue.Medium);
                page.Content()
                    .PaddingVertical(1, Unit.Centimetre)
                    .Column(x =>
                    {
                        x.Item().Text(Placeholders.LoremIpsum());

                        x.Spacing(2);

                        
                        x.Item().Text(Placeholders.LoremIpsum());

                        x.Item().Image(Placeholders.Image(200, 100));
                    });


















                page.Footer()
                    .AlignCenter()
                    .Text(x =>
                    {
                        x.Span("Seite ");
                        x.CurrentPageNumber();
                        x.Span(" von ");
                        x.TotalPages();

                    });

            });

        })
    .GeneratePdf("03_zusammenfassung_quer.pdf");
    
        }
















    }
}
