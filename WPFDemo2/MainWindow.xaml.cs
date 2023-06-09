using System;
using System.Collections.Generic;
using System.Windows;
using GalaSoft.MvvmLight;

namespace WPFDemo2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }

    public class MainViewModel : ViewModelBase
    {
        private List<Tratamento> tratamentos;
        private Tratamento tratamentoSelecionado;
        private OrgaoRisco orgaoRiscoSelecionado;

        public List<Tratamento> Tratamentos
        {
            get { return tratamentos; }
            set { Set(ref tratamentos, value); }
        }

        public Tratamento TratamentoSelecionado
        {
            get { return tratamentoSelecionado; }
            set
            {
                Set(ref tratamentoSelecionado, value);
                OrgaoRiscoSelecionado = null;
            }
        }

        public OrgaoRisco OrgaoRiscoSelecionado
        {
            get { return orgaoRiscoSelecionado; }
            set { Set(ref orgaoRiscoSelecionado, value); }
        }

        public MainViewModel()
        {
            Tratamentos = GetTratamentos();
        }

        private List<Tratamento> GetTratamentos()
        {
            // Retorna uma lista de tratamentos com dados de exemplo
            return new List<Tratamento>
            {
                new Tratamento
                {
                    Nome = "FAST FORWARD Lymphatic RT 5 fr x 520 cGy (2600 cGy)",
                    OrgaosRisco = new List<OrgaoRisco>
                    {
                        new OrgaoRisco
                        {
                            Nome = "Coracao",
                            VariaveisRisco = new List<VariavelRisco>
                            {
                                new VariavelRisco
                                {
                                    Nome = "VolDose 150 cGy (%)",
                                    
                                    ValorLimite = 30
                                },
                                new VariavelRisco
                                {
                                    Nome = "VolDose 700 cGy (%)",
                                    
                                    ValorLimite = 5
                                }
                            }
                        },
                        new OrgaoRisco
                        {
                            Nome = "Pulmao_esq",
                            VariaveisRisco = new List<VariavelRisco>
                            {
                                new VariavelRisco
                                {
                                    Nome = "VolDose 800 cGy (%)",
                                    
                                    ValorLimite = 25.0
                                }
                            }

                        },
                        new OrgaoRisco
                        {
                            Nome = "Pulmao_dir",
                            VariaveisRisco = new List<VariavelRisco>
                            {
                                new VariavelRisco
                                {
                                    Nome = "VolDose 800 cGy",

                                    ValorLimite = 25.0
                                }
                            }

                        },
                        new OrgaoRisco
                        {
                            Nome = "Mama_contra",
                            VariaveisRisco = new List<VariavelRisco>
                            {
                                new VariavelRisco
                                {
                                    Nome = "ALARA",

                                    
                                }
                            }

                        },
                        new OrgaoRisco
                        {
                            Nome = "Plexo_braq",
                            VariaveisRisco = new List<VariavelRisco>
                            {
                                new VariavelRisco
                                {
                                    Nome = "Dcc 105%",

                                    ValorLimite = 2730
                                }
                            }

                        }
                    }
                },
                new Tratamento
                {
                    Nome = "FAST FORWARD Lymphatic RT 5 fr x 520 cGy (2600 cGy)",
                    OrgaosRisco = new List<OrgaoRisco>
                    {
                        new OrgaoRisco
                        {
                            Nome = "Coracao",
                            VariaveisRisco = new List<VariavelRisco>
                            {
                                new VariavelRisco
                                {
                                    Nome = "VolDose 150 cGy (%)",

                                    ValorLimite = 30
                                },
                                new VariavelRisco
                                {
                                    Nome = "VolDose 700 cGy (%)",

                                    ValorLimite = 5
                                }
                            }
                        },
                        new OrgaoRisco
                        {
                            Nome = "Pulmao_esq",
                            VariaveisRisco = new List<VariavelRisco>
                            {
                                new VariavelRisco
                                {
                                    Nome = "VolDose 800 cGy (%)",

                                    ValorLimite = 25
                                }
                            }

                        },
                        new OrgaoRisco
                        {
                            Nome = "Pulmao_dir",
                            VariaveisRisco = new List<VariavelRisco>
                            {
                                new VariavelRisco
                                {
                                    Nome = "VolDose 800 cGy",

                                    ValorLimite = 15
                                }
                            }

                        },
                        new OrgaoRisco
                        {
                            Nome = "Mama_contra",
                            VariaveisRisco = new List<VariavelRisco>
                            {
                                new VariavelRisco
                                {
                                    Nome = "ALARA",


                                }
                            }

                        }
                        
                    }
                },
                new Tratamento
                {
                    Nome = "MAMA COM FOSSA UK START B 15fr x 266,7 cGy (4000 cGy)",
                    OrgaosRisco = new List<OrgaoRisco>
                    {
                        new OrgaoRisco
                        {
                            Nome = "Coracao",
                            VariaveisRisco = new List<VariavelRisco>
                            {
                                new VariavelRisco
                                {
                                    Nome = "VolDose 1600 cGy (%)",
                                    
                                    ValorLimite = 5
                                },
                                new VariavelRisco
                                {
                                    Nome = "VolDose 2000 cGy (%)",

                                    ValorAceitavel = 5
                                },
                                new VariavelRisco
                                {
                                    Nome = "Dméd (cGy)",
                                    ValorAceitavel = 400,
                                    ValorLimite = 320
                                }
                            }
                        },
                        new OrgaoRisco
                        {
                            Nome = "Pulmao_esq",
                            VariaveisRisco = new List<VariavelRisco>
                            {
                                new VariavelRisco
                                {
                                    Nome = "VolDose",
                                    ValorAceitavel = 25,
                                    ValorLimite = 20
                                }
                            }

                        },
                        new OrgaoRisco
                        {
                            Nome = "Pulmao_dir",
                            VariaveisRisco = new List<VariavelRisco>
                            {
                                new VariavelRisco
                                {
                                    Nome = "VolDose ",
                                    ValorAceitavel = 25,
                                    ValorLimite = 20
                                }
                            }

                        },
                        new OrgaoRisco
                        {
                            Nome = "Mama_contra",
                            VariaveisRisco = new List<VariavelRisco>
                            {
                                new VariavelRisco
                                {
                                    Nome = "ALARA",


                                }
                            }

                        },
                    }
                }
            };
        }
    }
    // Classe para representar uma variável de risco
    public class VariavelRisco
    {
        public string Nome { get; set; }
        public double ValorAceitavel { get; set; }
        public double ValorLimite { get; set; }
    }

    // Classe para representar um órgão de risco
    public class OrgaoRisco
    {
        public string Nome { get; set; }
        public List<VariavelRisco> VariaveisRisco { get; set; }

        public OrgaoRisco()
        {
            VariaveisRisco = new List<VariavelRisco>();
        }
    }

    // Classe para representar um tratamento
    public class Tratamento
    {
        public string Nome { get; set; }
        public List<OrgaoRisco> OrgaosRisco { get; set; }

        public Tratamento()
        {
            OrgaosRisco = new List<OrgaoRisco>();
        }
    }

    public class Program
    {
        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            app.Run(new MainWindow());
        }
    }
}
