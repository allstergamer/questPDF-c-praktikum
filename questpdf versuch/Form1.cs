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



                            x.Item().Padding(5).Text("Projektstatistik");














                            x.Item().Padding(10).LineHorizontal(1);


                            x.Item().AlignCenter().Table(table =>
                            {
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.ConstantColumn(125);
                                    columns.ConstantColumn(125);
                                    columns.ConstantColumn(125);
                                    columns.ConstantColumn(125);

                                });

                                table.Cell().Row(1).Column(1).Text(" Placeholder 1:");
                                table.Cell().Row(1).Column(2).Border(1).Text(" Erreichung");
                                table.Cell().Row(1).Column(3).Border(1).Text(" Wert");
                                table.Cell().Row(1).Column(4).Border(1).Text(" Beschreibung");

                                table.Cell().Row(2).Column(1).Text(" Placeholder 2");
                                table.Cell().Row(2).Column(2).Border(1).Text("  ");
                                table.Cell().Row(2).Column(3).Border(1).Text("  ");
                                table.Cell().Row(2).Column(4).Border(1).Text("  ");





                            });

                            x.Item().Padding(10).LineHorizontal(1);
                            x.Item().Text("Zielvereinbarungsuebersicht.pdf");







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


                page.Content()
                    .PaddingVertical(1, Unit.Centimetre)
                    .Column(x =>
                    {


                        x.Item().Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {

                                columns.ConstantColumn(155);
                                columns.ConstantColumn(760);
                                columns.ConstantColumn(155);
                            });
                            table.Cell().Row(1).Column(1).AlignRight().Text(" stand: ~datum~").SemiBold();
                            table.Cell().Row(1).Column(2).AlignCenter().Text("Bewertungsbogen Mitarbeiter/in ").FontSize(18).SemiBold();
                            table.Cell().Row(2).Column(2).AlignCenter().Text("(Sofern mi Folgenden Mitarbeiter genannt sind, sind auch Mitarbeiterinnen gemeint.) ");
                            table.Cell().RowSpan(2).Column(3).AlignRight().Image("Logo_LoB_IT.bmp");

                        });


                        // personen information

                        x.Item().Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                columns.ConstantColumn(105);
                                columns.ConstantColumn(430);
                                columns.ConstantColumn(105);
                                columns.ConstantColumn(430);

                            });

                            table.Cell().Row(1).Column(1).Border(1).Text(" Name:").SemiBold();
                            table.Cell().Row(2).Column(1).Border(1).Text(" Pnr.:").SemiBold();

                            table.Cell().Row(1).Column(2).Border(1).Text(" ~Name~");
                            table.Cell().Row(2).Column(2).Border(1).Text(" ~nummer~");

                            table.Cell().Row(1).Column(3).Border(1).Text(" Vorname:").SemiBold();
                            table.Cell().Row(2).Column(3).Border(1).Text(" Org.-Einheit:").SemiBold();

                            table.Cell().Row(1).Column(4).Border(1).Text(" ~Vorname~");
                            table.Cell().Row(2).Column(4).Border(1).Text(" ~Einheit~");



                        });



                        // personen information

                        x.Item().PaddingTop(50).Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                //muss 8 spalten und mindestenz 3 zeilen haben
                                columns.ConstantColumn(40);//135,400,135,400
                                columns.ConstantColumn(415);
                                columns.ConstantColumn(40);
                                columns.ConstantColumn(40);
                                columns.ConstantColumn(40);
                                columns.ConstantColumn(40);
                                columns.ConstantColumn(40);
                                columns.ConstantColumn(415);

                            });

                            table.Cell().Row(1).Column(1);
                            table.Cell().Row(1).Column(2);
                            table.Cell().Row(1).Column(3).TranslateX(0).TranslateY(-0).Rotate(270).Unconstrained().Scale(0.85f).Text(" Erwartung\n nicht\n erfüllt");
                            table.Cell().Row(1).Column(4);
                            table.Cell().Row(1).Column(5);
                            table.Cell().Row(1).Column(6);
                            table.Cell().Row(1).Column(7).TranslateX(0).TranslateY(-0).Rotate(270).Unconstrained().Scale(0.85f).Text(" Erwartung\n deutlich\n übertroffen");
                            table.Cell().Row(1).Column(8);


                            table.Cell().Row(2).Column(1).Border(1).AlignCenter().Text(" Nr.").Bold();
                            table.Cell().Row(2).Column(2).Border(1).Text("Bewertungskriterium");
                            table.Cell().Row(2).Column(3).Background(Colors.Grey.Lighten1).Border(1).AlignCenter().Text(" 1").Bold();
                            table.Cell().Row(2).Column(4).Border(1).AlignCenter().Text(" 2").Bold();
                            table.Cell().Row(2).Column(5).Border(1).AlignCenter().Text(" 3").Bold();
                            table.Cell().Row(2).Column(6).Border(1).AlignCenter().Text(" 4").Bold();
                            table.Cell().Row(2).Column(7).Background(Colors.Grey.Lighten1).Border(1).AlignCenter().Text(" 5").Bold();
                            table.Cell().Row(2).Column(8).Border(1).Text(" Begründung").Bold();


                            table.Cell().Row(3).Column(1).Border(1).AlignCenter().Text(" 1").Bold();
                            table.Cell().Row(3).Column(2).Border(1).Text(" ~kriterium 1~");
                            table.Cell().Row(3).Column(3).Background(Colors.Grey.Lighten1).Border(1).Text(" ").Bold();
                            table.Cell().Row(3).Column(4).Border(1).Text(" ").Bold();
                            table.Cell().Row(3).Column(5).Border(1).Text(" ").Bold();
                            table.Cell().Row(3).Column(6).Border(1).Text(" ").Bold();
                            table.Cell().Row(3).Column(7).Background(Colors.Grey.Lighten1).Border(1).Text(" ").Bold();
                            table.Cell().Row(3).Column(8).Border(1).Text(" placeholder");


                            table.Cell().Row(4).Column(1).Border(1).AlignCenter().Text(" 2").Bold();
                            table.Cell().Row(4).Column(2).Border(1).Text(" ~kriterium 2~");
                            table.Cell().Row(4).Column(3).Background(Colors.Grey.Lighten1).Border(1).Text(" ").Bold();
                            table.Cell().Row(4).Column(4).Border(1).Text(" ").Bold();
                            table.Cell().Row(4).Column(5).Border(1).Text(" ").Bold();
                            table.Cell().Row(4).Column(6).Border(1).Text(" ").Bold();
                            table.Cell().Row(4).Column(7).Background(Colors.Grey.Lighten1).Border(1).Text(" ").Bold();
                            table.Cell().Row(4).Column(8).Border(1).Text(" placeholder");

                            table.Cell().Row(5).ColumnSpan(4).PaddingTop(15).AlignRight().Text("Summe Leistungsbewertung (Punkte) ").Bold();
                            table.Cell().Row(5).Column(5).PaddingTop(15).BorderBottom(1).BorderTop(1).BorderLeft(1).AlignRight();
                            table.Cell().Row(5).Column(6).PaddingTop(15).BorderBottom(1).BorderTop(1).AlignRight();
                            table.Cell().Row(5).Column(7).PaddingTop(15).BorderBottom(1).BorderTop(1).BorderRight(1).AlignRight();
                        });
                        x.Spacing(15);

                        x.Item().Text("Bitte beachten Sie, dass über das oben genannte Ergebnis sowie die Gesprächsinhalte bis zum Abschluss aller Feedbackgespräche in Ihrem Bereich Stillschweigen zu bewahren ist").Bold();






                        x.Item().PaddingTop(30).Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                //muss 8 spalten und mindestenz 3 zeilen haben
                                columns.ConstantColumn(180);//135,400,135,400
                                columns.ConstantColumn(160);
                                columns.ConstantColumn(180);
                                columns.ConstantColumn(160);
                                columns.ConstantColumn(180);
                                columns.ConstantColumn(180);


                            });



                            table.Cell().Row(1).Column(1).AlignRight().Text(" Datum des Feedbackgesprächs:");
                            table.Cell().Row(1).Column(2).BorderBottom(1);
                            table.Cell().Row(1).Column(3).AlignRight().Text(" Unterschrifft Führungskraft:");
                            table.Cell().Row(1).Column(4).BorderBottom(1);
                            table.Cell().Row(1).Column(5).AlignRight().Text(" Unterschrifft Mitarbeiter:");
                            table.Cell().Row(1).Column(6).BorderBottom(1);
                        });




                        x.Item().PaddingTop(50).Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                //muss 8 spalten und mindestenz 3 zeilen haben
                                columns.ConstantColumn(50);//135,400,135,400
                                columns.ConstantColumn(150);
                                columns.ConstantColumn(240);
                                columns.ConstantColumn(130);
                                columns.ConstantColumn(100);
                                columns.ConstantColumn(100);
                                columns.ConstantColumn(100);
                                columns.ConstantColumn(100);
                                columns.ConstantColumn(100);

                            });

                            table.Cell().Row(1).Column(1).Border(1).Text(" ID").SemiBold();
                            table.Cell().Row(1).Column(2).Border(1).Text(" Projektbezeichnung").SemiBold();
                            table.Cell().Row(1).Column(3).Border(1).Text(" Beschreibung").SemiBold();
                            table.Cell().Row(1).Column(4).Border(1).Text(" Beurteilungszeitraum").SemiBold();
                            table.Cell().Row(1).Column(5).Border(1).Text(" Finanzvolumen").SemiBold();
                            table.Cell().Row(1).Column(6).Border(1).Text(" Führungskraft").SemiBold();
                            table.Cell().Row(1).Column(7).Border(1).Text(" Anzahl\n Beschäftigte").SemiBold();
                            table.Cell().Row(1).Column(8).Border(1).Text(" Kostenstelle").SemiBold();
                            table.Cell().Row(1).Column(9).Border(1).Text(" Barcode").SemiBold();


                            //Inhalt
                            // für weiter e zeilen muss row(x) um eins erhöht werden der rest kann genauso bleiben

                            table.Cell().Row(2).Column(1).Border(1).Text(" ");
                            table.Cell().Row(2).Column(2).Border(1).Text(" ");
                            table.Cell().Row(2).Column(3).Border(1).Text(" ");
                            table.Cell().Row(2).Column(4).Border(1).Text(" ");
                            table.Cell().Row(2).Column(5).Border(1).Text(" ");
                            table.Cell().Row(2).Column(6).Border(1).Text(" ");
                            table.Cell().Row(2).Column(7).Border(1).Text(" ");
                            table.Cell().Row(2).Column(8).Border(1).Text(" ");
                            table.Cell().Row(2).Column(9).Border(1).Text(" ");


                        });





                        x.Item().Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                //muss 8 spalten und mindestenz 3 zeilen haben
                                columns.ConstantColumn(1070);

                            });

                            table.Cell().Row(1).Column(1).Border(1).AlignRight().Hyperlink("https://www.kommSolutions.de").Text(" kommSolutions ").SemiBold().FontSize(16);



                        });



                        x.Item().PaddingTop(50).Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                //
                                columns.ConstantColumn(36);//135,400,135,400
                                columns.ConstantColumn(76);
                                columns.ConstantColumn(56);
                                columns.ConstantColumn(56);
                                columns.ConstantColumn(128);
                                columns.ConstantColumn(66);
                                columns.ConstantColumn(66);
                                columns.ConstantColumn(66);
                                columns.ConstantColumn(76);
                                columns.ConstantColumn(86);
                                columns.ConstantColumn(40);
                                columns.ConstantColumn(66);
                                columns.ConstantColumn(40);
                                columns.ConstantColumn(40);
                                columns.ConstantColumn(40);
                                columns.ConstantColumn(66);
                                columns.ConstantColumn(66);
                            });

                            table.Cell().Row(1).Column(1).Border(1).Text(" ID").SemiBold();
                            table.Cell().Row(1).Column(2).Border(1).Text(" Nachname").SemiBold();
                            table.Cell().Row(1).Column(3).Border(1).Text(" Vor-\n name").SemiBold();
                            table.Cell().Row(1).Column(4).Border(1).Text(" Personal-\n nummer").SemiBold();
                            table.Cell().Row(1).Column(5).Border(1).Text(" Email").SemiBold();
                            table.Cell().Row(1).Column(6).Border(1).Text(" Projekt").SemiBold();
                            table.Cell().Row(1).Column(7).Border(1).Text(" Gruppe").SemiBold();
                            table.Cell().Row(1).Column(8).Border(1).Text(" Entgelt-\n Faktor").SemiBold();
                            table.Cell().Row(1).Column(9).Border(1).Text(" Arbeitszeit").SemiBold();
                            table.Cell().Row(1).Column(10).Border(1).Text(" Fachabteilung").SemiBold();
                            table.Cell().Row(1).Column(11).Border(1).Text(" Durch\n wahl").SemiBold();
                            table.Cell().Row(1).Column(12).Border(1).Text(" Barcode").SemiBold();
                            table.Cell().Row(1).Column(13).Border(1).Text(" Frei-\n feld 2").SemiBold();
                            table.Cell().Row(1).Column(14).Border(1).Text(" Frei-\n feld 3").SemiBold();
                            table.Cell().Row(1).Column(15).Border(1).Text(" Frei-\n feld 4").SemiBold();
                            table.Cell().Row(1).Column(16).Border(1).Text(" Beschäftigt\n seit").SemiBold();
                            table.Cell().Row(1).Column(17).Border(1).Text(" Beschäftigt\n bis").SemiBold();


                            //Inhalt
                            // für weiter e zeilen muss row(x) um eins erhöht werden der rest kann genauso bleiben

                            table.Cell().Row(2).Column(1).Border(1).Text(" ");
                            table.Cell().Row(2).Column(2).Border(1).Text(" ");
                            table.Cell().Row(2).Column(3).Border(1).Text(" ");
                            table.Cell().Row(2).Column(4).Border(1).Text(" ");
                            table.Cell().Row(2).Column(5).Border(1).Text(" ");
                            table.Cell().Row(2).Column(6).Border(1).Text(" ");
                            table.Cell().Row(2).Column(7).Border(1).Text(" ");
                            table.Cell().Row(2).Column(8).Border(1).Text(" ");
                            table.Cell().Row(2).Column(9).Border(1).Text(" ");
                            table.Cell().Row(2).Column(10).Border(1).Text(" ");
                            table.Cell().Row(2).Column(11).Border(1).Text(" ");
                            table.Cell().Row(2).Column(12).Border(1).Text(" ");
                            table.Cell().Row(2).Column(13).Border(1).Text(" ");
                            table.Cell().Row(2).Column(14).Border(1).Text(" ");
                            table.Cell().Row(2).Column(15).Border(1).Text(" ");
                            table.Cell().Row(2).Column(16).Border(1).Text(" ");
                            table.Cell().Row(2).Column(17).Border(1).Text(" ");


                        });












                        x.Item().PaddingTop(50).Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                //
                                columns.ConstantColumn(36);//135,400,135,400
                                columns.ConstantColumn(238);
                                columns.ConstantColumn(186);
                                columns.ConstantColumn(116);
                                columns.ConstantColumn(116);
                                columns.ConstantColumn(186);
                                columns.ConstantColumn(96);
                                columns.ConstantColumn(96);
                            });

                            table.Cell().Row(1).Column(1).Border(1).Text(" ID").SemiBold();
                            table.Cell().Row(1).Column(2).Border(1).Text(" Teambezeichnung").SemiBold();
                            table.Cell().Row(1).Column(3).Border(1).Text(" Messgröße").SemiBold();
                            table.Cell().Row(1).Column(4).Border(1).Text(" Ziel (100%) ").SemiBold();
                            table.Cell().Row(1).Column(5).Border(1).Text(" Ergebnis").SemiBold();
                            table.Cell().Row(1).Column(6).Border(1).Text(" Projekt").SemiBold();
                            table.Cell().Row(1).Column(7).Border(1).Text(" Gruppe").SemiBold();
                            table.Cell().Row(1).Column(8).Border(1).Text(" Teammitglieder").SemiBold();

                            //inhalt
                            table.Cell().Row(2).Column(1).Border(1).Text(" ");
                            table.Cell().Row(2).Column(2).Border(1).Text(" ");
                            table.Cell().Row(2).Column(3).Border(1).Text(" ");
                            table.Cell().Row(2).Column(4).Border(1).Text(" ").SemiBold();
                            table.Cell().Row(2).Column(5).Border(1).Text(" ").SemiBold();
                            table.Cell().Row(2).Column(6).Border(1).Text(" ").SemiBold();
                            table.Cell().Row(2).Column(7).Border(1).Text(" ").SemiBold();
                            table.Cell().Row(2).Column(8).Border(1).Text(" ").SemiBold();




                        });

                        x.Item().Text("Teamzieluebericht");






























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
