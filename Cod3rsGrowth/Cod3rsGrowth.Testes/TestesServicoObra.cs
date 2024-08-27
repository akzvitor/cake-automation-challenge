using Cod3rsGrowth.Dominio.Entidades;
using Cod3rsGrowth.Dominio.Enums;
using Cod3rsGrowth.Servico.Servicos;
using Cod3rsGrowth.Testes.ConfiguracaoAmbienteTeste;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Cod3rsGrowth.Testes
{
    public class TestesServicoObra : TesteBase
    {
        private ServicoObra? _servicoObra;
        private readonly FiltroObra _filtro;

        public TestesServicoObra()
        {
            CarregarServico();
            _servicoObra.ObterTodos(_filtro).Clear();
            InicializarBancoDeDados();
        }

        private void CarregarServico()
        {
            _servicoObra = ServiceProvider.GetService<ServicoObra>()
                ?? throw new Exception($"Erro ao obter servico [{nameof(ServicoObra)}]");
        }

        private List<Obra> InicializarDadosMockados()
        {
            List<Obra> listaDeObras = new()
            {
                new Obra
                {
                    Id = 100,
                    Titulo = "Re:Zero kara Hajimeru Isekai Seikatsu",
                    Autor = "Tappei Nagatsuki",
                    FoiFinalizada = false,
                    Formato = Formato.WebNovel,
                    Generos = new List<Genero>
                    {
                        Genero.Sobrenatural,
                        Genero.Psicologico,
                        Genero.Misterio
                    },
                    InicioPublicacao = DateTime.Parse("Jan 24, 2014"),
                    NumeroCapitulos = 20,
                    ValorObra = 0,
                    Sinopse = "Subaru Natsuki estava apenas tentando chegar à loja de conveniência, " +
                    "mas acabou convocado para outro mundo. Ele encontra coisas comuns – situações de " +
                    "risco de vida, belezas de cabelos prateados, fadas felinas – você sabe, coisas normais. " +
                    "Tudo isso já seria ruim o suficiente, mas ele também ganhou a habilidade mágica " +
                    "mais inconveniente de todas: viajar no tempo, mas ele precisa morrer para usá-la. " +
                    "Como você retribui alguém que salvou sua vida quando tudo o que você pode fazer é morrer?"
                },
                new Obra
                {
                    Id = 101,
                    Titulo = "Hagane no Renkinjutsushi",
                    Autor = "Hiromu Arakawa",
                    FoiFinalizada = true,
                    Formato = Formato.Manga,
                    Generos = new List<Genero>
                    {
                        Genero.Acao,
                        Genero.Aventura,
                        Genero.Drama,
                        Genero.Fantasia
                    },
                    InicioPublicacao = DateTime.Parse("Jul 12, 2001"),
                    NumeroCapitulos = 116,
                    ValorObra = 20,
                    Sinopse = "A alquimia destruiu os corpos dos irmãos Elric. O vínculo deles pode torná-los " +
                    "inteiros novamente? Neste mundo, os alquimistas são aqueles que estudam e realizam a " +
                    "arte da transmutação alquímica – a ciência da manipulação e transformação da matéria. Eles estão " +
                    "sujeitos à Lei da Troca Equivalente: para ganhar algo, é preciso sacrificar algo de igual valor. " +
                    "Em um ritual alquímico que deu errado, Edward Elric perdeu o braço e a perna, e seu irmão Alphonse " +
                    "se tornou nada além de uma alma em uma armadura. Equipado com membros mecânicos de “correio " +
                    "automático”, Edward se torna um alquimista do estado, buscando a única coisa que pode restaurar o " +
                    "corpo dele e de seu irmão... a lendária Pedra Filosofal."
                },
                new Obra
                {
                    Id = 102,
                    Titulo = "Na Honjaman Level Up",
                    Autor = "Chu-Gong",
                    FoiFinalizada = true,
                    Formato = Formato.Manhwa,
                    Generos = new List<Genero>
                    {
                        Genero.Acao,
                        Genero.Aventura,
                        Genero.Fantasia
                    },
                    InicioPublicacao = DateTime.Parse("Mar 4, 2018"),
                    NumeroCapitulos = 201,
                    ValorObra = 70,
                    Sinopse = "Num mundo onde seres despertos chamados “Caçadores” devem lutar contra monstros mortais " +
                    "para proteger a humanidade, Sung Jinwoo, apelidado de “o caçador mais fraco de toda a humanidade”, " +
                    "encontra-se numa luta constante pela sobrevivência. Um dia, depois de um encontro brutal em uma " +
                    "masmorra dominada destruir seu grupo e ameaçar acabar com sua vida, um misterioso Sistema o escolhe " +
                    "como único jogador: Jinwoo teve a rara oportunidade de aprimorar suas habilidades, possivelmente além " +
                    "de quaisquer limites conhecidos. . Acompanhe a jornada de Jinwoo enquanto ele enfrenta inimigos cada " +
                    "vez mais fortes, tanto humanos quanto monstros, para descobrir os segredos profundos das masmorras e a " +
                    "extensão máxima de seus poderes."
                }
            };

            return listaDeObras;
        }

        private void InicializarBancoDeDados()
        {
            var listaDeObras = InicializarDadosMockados();

            listaDeObras.ForEach(item => _servicoObra.Criar(item));    
        }

        [Fact]
        public void ObterTodos_ComDadosDisponiveis_DeveRetornarAListaDeObras()
        {
            var listaMock = InicializarDadosMockados();

            var listaDoBanco = _servicoObra.ObterTodos(_filtro);

            Assert.NotNull(listaDoBanco);
            Assert.Equivalent(listaMock, listaDoBanco);
        }

        [Fact]
        public void ObterTodos_ComDadosDisponiveis_DeveRetornarUmaListaDoTipoObra()
        {
            var listaDoBanco = _servicoObra.ObterTodos(_filtro);

            Assert.NotNull(listaDoBanco);
            Assert.IsType<List<Obra>>(listaDoBanco);
        }

        [Fact]
        public void ObterPorId_InformandoIdValido_DeveRetornarObraCorreta()
        {
            var listaMock = InicializarDadosMockados();
            var idValidoInformado = 100;
            var obraMock = listaMock.FirstOrDefault();

            var obra = _servicoObra.ObterPorId(idValidoInformado);

            Assert.NotNull(obra);
            Assert.Equivalent(obraMock, obra);
        }

        [Fact]
        public void ObterPorId_InformandoIdInvalido_DeveRetornarExcecaoObjetoNaoEncontrado()
        {
            var idInvalidoInformado = 200;

            var excecao = Assert.Throws<Exception>(() => _servicoObra.ObterPorId(idInvalidoInformado));

            Assert.Equal($"O ID informado ({idInvalidoInformado}) é inválido. Obra não encontrada.", excecao.Message);
        }

        [Fact]
        public void ObterPorId_InformandoIdValido_DeveRetornarUmObjetoDoTipoObra()
        {
            var idValidoInformado = 102;

            var obra = _servicoObra.ObterPorId(idValidoInformado);

            Assert.NotNull(obra);
            Assert.IsType<Obra>(obra);
        }

        //Método Criar
        [Fact]
        public void Criar_ComDadosValidos_DeveCriarObjetoComSucesso()
        {
            var listaMock = InicializarDadosMockados();
            var novaObra = listaMock.FirstOrDefault();

            var novaObraCadastrada = _servicoObra.Criar(novaObra);

            Assert.NotNull(novaObraCadastrada?.Id);
            Assert.Equivalent(novaObra, novaObraCadastrada);
        }

        [Theory]
        [InlineData("")]
        [InlineData("      ")]
        [InlineData(null)]
        public void Criar_ComTituloNuloOuVazio_DeveRetornarExcecao(string tituloInvalido)
        {
            var listaMock = InicializarDadosMockados();
            var novaObra = listaMock.FirstOrDefault();
            novaObra.Titulo = tituloInvalido;
            var mensagemDeErro = "O titulo da obra é obrigatório.";

            var excecao = Assert.Throws<ValidationException>(() => _servicoObra.Criar(novaObra));

            Assert.Equal(mensagemDeErro, excecao.Message);
        }

        [Fact]
        public void Criar_ComTituloMaiorQue2000Caracteres_DeveRetornarExcecao()
        {
            var listaMock = InicializarDadosMockados();
            var novaObra = listaMock.FirstOrDefault();
            novaObra.Titulo = "My Life Is Just As Wrong As I Expected After Traveling to Another World Where " +
                "I’m Surrounded By Cute Girls At A Magical High School And Am Also The Fabled Hero of Legend, " +
                "But Before I Tell You That Story I Have To Tell You This Story, In Which I Was Walking " +
                "Along With My Unbelievably, Impossibly Cute Younger Sister Who Doesn’t Like Me At All, " +
                "And She Said To Me It Was My Fault She Wasn’t Popular No Matter How She Looked At It As We " +
                "Walked To School Together, And We Stopped To Look At A Garden, Which Had A Flower Whose Name " +
                "I Don’t Remember, When Suddenly A Portal Opened Up To Another World And When I Landed In A " +
                "Field And My Face Was Buried In The Largest Pair of Boobs I’d Ever Seen, And My Sister Hit " +
                "Me And Called Me An Idiot While Blushing, But Then The Girl I Landed On Saw The Birthmark On " +
                "My Hand And Gasped And She Grabbed My Hand And I Blushed But She Started Dragging Me Away " +
                "And My Sister Got Mad And Chased After Us And I Asked Where We Were Going, And She Said She " +
                "Was Taking Us To Grimheart Magic School, Where She Was The School President, And Then I Gasped " +
                "Because I Was Now In A Magical World, And When We Got To The School Which Was A Giant Castle " +
                "I Asked The Girl What Her Name Was And She Said It Was Akane Yuusha, Which I Thought Was A " +
                "Tad Strange Since She Had Blonde Hair And Blue Eyes And The Entire Aesthetic Of The School " +
                "Seemed Very Ancient European, But I Forgot About All Of That When She Told Me We Needed To " +
                "See The Headmaster Because She Had Been Taught That The Mark On My Hand Was The Symbol Of " +
                "The Reincarnation Of The Legendary Dragon Hero Of Legendary Literature, And I Said That Was " +
                "A Cool Thing To Be Taught Because At Our School The Only Book We Learned Was Atlas Shrugged, " +
                "And She Asked What That Was And I Told Her I Was The Book Our Society Based Its Philosophy On " +
                "A Speech From, And She Asked Me To Recite The Speech, Which I Did, And The Speech Went “For " +
                "A Speech From, And She Asked Me To Recite The Speech, Which I Did, And The Speech Went “For " +
                "A Speech From, And She Asked Me To Recite The Speech, Which I Did, And The Speech Went “For " +
                "A Speech From, And She Asked Me To Recite The Speech, Which I Did, And The Speech Went “For " +
                "Twelve Years You Have Been Asking…                                                          ";
            var mensagemDeErro = "O título pode ter no máximo 2000 caracteres.";

            var excecao = Assert.Throws<ValidationException>(() => _servicoObra.Criar(novaObra));

            Assert.Equal(mensagemDeErro, excecao.Message);
        }

        [Theory]
        [InlineData("")]
        [InlineData("      ")]
        [InlineData(null)]
        public void Criar_ComNomeDoAutorNuloOuVazio_DeveRetornarExcecao(string autorInvalido)
        {
            var listaMock = InicializarDadosMockados();
            var novaObra = listaMock.FirstOrDefault();
            novaObra.Autor = autorInvalido;
            var mensagemDeErro = "O nome do autor da obra é obrigatório.";

            var excecao = Assert.Throws<ValidationException>(() => _servicoObra.Criar(novaObra));

            Assert.Equal(mensagemDeErro, excecao.Message);
        }

        [Theory]
        [InlineData("&&%*$*(")]
        [InlineData("Aaaaa@@#$")]
        public void Criar_ComCaracteresInvalidosNoNomeDoAutor_DeveRetornarExcecao(string autorInvalido)
        {
            var listaMock = InicializarDadosMockados();
            var novaObra = listaMock.FirstOrDefault();
            novaObra.Autor = autorInvalido;
            var mensagemDeErro = "O nome do autor deve conter apenas letras, números, espaços ou símbolos como - ou _.";

            var excecao = Assert.Throws<ValidationException>(() => _servicoObra.Criar(novaObra));

            Assert.Equal(mensagemDeErro, excecao.Message);
        }

        [Fact]
        public void Criar_ComNomeDoAutorMaiorQue150Caracteres_DeveRetornarExcecao()
        {
            var listaMock = InicializarDadosMockados();
            var novaObra = listaMock.FirstOrDefault();
            novaObra.Autor = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            var mensagemDeErro = "O nome do autor deve ter até 150 caracteres.";

            var excecao = Assert.Throws<ValidationException>(() => _servicoObra.Criar(novaObra));

            Assert.Equal(mensagemDeErro, excecao.Message);
        }

        [Theory]
        [InlineData("")]
        [InlineData("      ")]
        [InlineData(null)]
        public void Criar_ComSinopseNulaOuVazia_DeveRetornarExcecao(string sinopseInvalida)
        {
            var listaMock = InicializarDadosMockados();
            var novaObra = listaMock.FirstOrDefault();
            novaObra.Sinopse = sinopseInvalida;
            var mensagemDeErro = "A obra deve ter uma sinopse.";

            var excecao = Assert.Throws<ValidationException>(() => _servicoObra.Criar(novaObra));

            Assert.Equal(mensagemDeErro, excecao.Message);
        }

        [Fact]
        public void Criar_ComSinopseMaiorQue2000Caracteres_DeveRetornarExcecao()
        {
            var listaMock = InicializarDadosMockados();
            var novaObra = listaMock.FirstOrDefault();
            novaObra.Sinopse = "My Life Is Just As Wrong As I Expected After Traveling to Another World Where " +
                "I’m Surrounded By Cute Girls At A Magical High School And Am Also The Fabled Hero of Legend, " +
                "But Before I Tell You That Story I Have To Tell You This Story, In Which I Was Walking " +
                "Along With My Unbelievably, Impossibly Cute Younger Sister Who Doesn’t Like Me At All, " +
                "And She Said To Me It Was My Fault She Wasn’t Popular No Matter How She Looked At It As We " +
                "Walked To School Together, And We Stopped To Look At A Garden, Which Had A Flower Whose Name " +
                "I Don’t Remember, When Suddenly A Portal Opened Up To Another World And When I Landed In A " +
                "Field And My Face Was Buried In The Largest Pair of Boobs I’d Ever Seen, And My Sister Hit " +
                "Me And Called Me An Idiot While Blushing, But Then The Girl I Landed On Saw The Birthmark On " +
                "My Hand And Gasped And She Grabbed My Hand And I Blushed But She Started Dragging Me Away " +
                "And My Sister Got Mad And Chased After Us And I Asked Where We Were Going, And She Said She " +
                "Was Taking Us To Grimheart Magic School, Where She Was The School President, And Then I Gasped " +
                "Because I Was Now In A Magical World, And When We Got To The School Which Was A Giant Castle " +
                "I Asked The Girl What Her Name Was And She Said It Was Akane Yuusha, Which I Thought Was A " +
                "Tad Strange Since She Had Blonde Hair And Blue Eyes And The Entire Aesthetic Of The School " +
                "Seemed Very Ancient European, But I Forgot About All Of That When She Told Me We Needed To " +
                "See The Headmaster Because She Had Been Taught That The Mark On My Hand Was The Symbol Of " +
                "The Reincarnation Of The Legendary Dragon Hero Of Legendary Literature, And I Said That Was " +
                "A Cool Thing To Be Taught Because At Our School The Only Book We Learned Was Atlas Shrugged, " +
                "And She Asked What That Was And I Told Her I Was The Book Our Society Based Its Philosophy On " +
                "A Speech From, And She Asked Me To Recite The Speech, Which I Did, And The Speech Went “For " +
                "A Speech From, And She Asked Me To Recite The Speech, Which I Did, And The Speech Went “For " +
                "A Speech From, And She Asked Me To Recite The Speech, Which I Did, And The Speech Went “For " +
                "A Speech From, And She Asked Me To Recite The Speech, Which I Did, And The Speech Went “For " +
                "Twelve Years You Have Been Asking…                                                          ";
            var mensagemDeErro = "A sinopse deve ter no máximo 2000 caracteres.";

            var excecao = Assert.Throws<ValidationException>(() => _servicoObra.Criar(novaObra));

            Assert.Equal(mensagemDeErro, excecao.Message);
        }

        [Fact]
        public void Criar_ComNumeroDeCapitulosMenorQueUm_DeveRetornarExcecao()
        {
            var listaMock = InicializarDadosMockados();
            var novaObra = listaMock.FirstOrDefault();
            novaObra.NumeroCapitulos = -187;
            var mensagemDeErro = "A obra deve ter pelo menos 1 capítulo.";

            var excecao = Assert.Throws<ValidationException>(() => _servicoObra.Criar(novaObra));

            Assert.Equal(mensagemDeErro, excecao.Message);
        }

        [Fact]
        public void Criar_ComValorDaObraNegativo_DeveRetornarExcecao()
        {
            var listaMock = InicializarDadosMockados();
            var novaObra = listaMock.FirstOrDefault();
            novaObra.ValorObra = -40;
            var mensagemDeErro = "O valor da obra não pode ser negativo.";

            var excecao = Assert.Throws<ValidationException>(() => _servicoObra.Criar(novaObra));

            Assert.NotNull(excecao);
            Assert.Equal(mensagemDeErro, excecao.Message);
        }

        [Fact]
        public void Criar_ComDataDeInicioDaPublicacaoNulaOuVazia_DeveRetornarExcecao()
        {
            var listaMock = InicializarDadosMockados();
            var novaObra = listaMock.FirstOrDefault();
            novaObra.InicioPublicacao = DateTime.MinValue;
            var mensagemDeErro = "A data de início da publicação da obra deve ser informada.";

            var excecao = Assert.Throws<ValidationException>(() => _servicoObra.Criar(novaObra));

            Assert.Equal(mensagemDeErro, excecao.Message);
        }

        [Fact]
        public void Criar_ComDataDeInicioDaPublicacaoNoFuturo_DeveRetornarExcecao()
        {
            var listaMock = InicializarDadosMockados();
            var novaObra = listaMock.FirstOrDefault();
            novaObra.InicioPublicacao = DateTime.Parse("Jul 19, 3000");
            var mensagemDeErro = "Data inválida. Não é possível colocar uma data futura.";

            var excecao = Assert.Throws<ValidationException>(() => _servicoObra.Criar(novaObra));

            Assert.Equal(mensagemDeErro, excecao.Message);
        }

        [Fact]
        public void Criar_ComFormatoDeObraInvalido_DeveRetornarExcecao()
        {
            var listaMock = InicializarDadosMockados();
            var novaObra = listaMock.FirstOrDefault();
            novaObra.Formato = (Formato)32;
            var mensagemDeErro = "Formato de obra inválido.";

            var excecao = Assert.Throws<ValidationException>(() => _servicoObra.Criar(novaObra));

            Assert.Equal(mensagemDeErro, excecao.Message);
        }

        [Fact]
        public void Criar_ComListaDeGenerosVazia_DeveRetornarExcecao()
        {
            var listaMock = InicializarDadosMockados();
            var novaObra = listaMock.FirstOrDefault();
            novaObra.Generos = new List<Genero> { };
            var mensagemDeErro = "O(s) gênero(s) da obra deve(m) ser informado(s).";

            var excecao = Assert.Throws<ValidationException>(() => _servicoObra.Criar(novaObra));

            Assert.Equal(mensagemDeErro, excecao.Message);
        }

        [Fact]
        public void Criar_ComListaDeGenerosMaiorQue10_DeveRetornarExcecao()
        {
            var listaMock = InicializarDadosMockados();
            var novaObra = listaMock.FirstOrDefault();
            novaObra.Generos = new List<Genero>
            {
                Genero.Acao,
                Genero.ArtesMarciais,
                Genero.Aventura,
                Genero.Comedia,
                Genero.Drama,
                Genero.Romance,
                Genero.Psicologico,
                Genero.Historico,
                Genero.Musical,
                Genero.Horror,
                Genero.SciFi,
                Genero.MahouShoujo
            };
            var mensagemDeErro = "O limite de gêneros em uma única obra é 10.";

            var excecao = Assert.Throws<ValidationException>(() => _servicoObra.Criar(novaObra));

            Assert.Equal(mensagemDeErro, excecao.Message);
        }

        [Fact]
        public void Criar_ComGeneroInvalidoNaListaDeGeneros_DeveRetornarExcecao()
        {
            var listaMock = InicializarDadosMockados();
            var novaObra = listaMock.FirstOrDefault();
            novaObra.Generos = new List<Genero> { (Genero)456 };
            var mensagemDeErro = "Genero informado inválido.";

            var excecao = Assert.Throws<ValidationException>(() => _servicoObra.Criar(novaObra));

            Assert.Equal(mensagemDeErro, excecao.Message);
        }

        //Método Editar
        [Fact]
        public void Editar_ComTodosOsDadosValidos_DeveEditarTodaAObraSelecionadaCorretamente()
        {
            var obraEditada = new Obra
            {
                Id = 101,
                Titulo = "SPY × FAMILY",
                Autor = "Tatsuya Endou",
                FoiFinalizada = false,
                Formato = Formato.Manga,
                Generos = new List<Genero>
                {
                    Genero.Acao,
                    Genero.Comedia,
                    Genero.Sobrenatural,
                    Genero.SliceOfLife
                },
                InicioPublicacao = DateTime.Parse("Mar 25, 2019"),
                NumeroCapitulos = 98,
                ValorObra = 30,
                Sinopse = "O mestre espião de codinome <Crepúsculo> passou seus dias em missões secretas, tudo pelo " +
                "sonho de um mundo melhor. Mas um dia, ele recebe uma nova ordem particularmente difícil do comando. " +
                "Para sua missão, ele deverá formar uma família temporária e começar uma nova vida?! Um Espião/Ação/Comédia " +
                "sobre uma família única!"
            };

            var obraNoBanco = _servicoObra.Editar(obraEditada);

            Assert.Equivalent(obraEditada, obraNoBanco);
        }

        [Fact]
        public void Editar_ComDadosValidos_DeveEditarDadosDaObraSelecionadaCorretamente()
        {
            var listaMock = InicializarDadosMockados();
            var obraEditada = listaMock.FirstOrDefault();
            obraEditada.Autor = "nezumiironyanko";
            obraEditada.Titulo = "Emilia-sama no Sekai wa Subarashii";

            var obraNoBanco = _servicoObra.Editar(obraEditada);

            Assert.Equivalent(obraEditada, obraNoBanco);
        }

        [Fact]
        public void Editar_ComIdInexistente_DeveRetornarExcecao()
        {
            var listaMock = InicializarDadosMockados();
            var obraASerEditada = listaMock.FirstOrDefault();
            var idInexistente =  2000;
            obraASerEditada.Id = idInexistente;
            obraASerEditada.Titulo = "Gintama";
            var mensagemDeErroEsperada = $"O ID informado ({idInexistente}) é inválido. Obra não encontrada.";

            var excecao = Assert.Throws<Exception>(() => _servicoObra.Editar(obraASerEditada));

            Assert.Equal(mensagemDeErroEsperada, excecao.Message);
        }

        [Fact]
        public void Editar_SemId_DeveRetornarExcecaoDefinidaNoRuleSetDeEdicao()
        {
            var obraEditada = new Obra
            {
                Titulo = "SPY × FAMILY",
                Autor = "Tatsuya Endou",
                FoiFinalizada = false,
                Formato = Formato.Manga,
                Generos = new List<Genero>
                {
                    Genero.Acao,
                    Genero.Comedia,
                    Genero.Sobrenatural,
                    Genero.SliceOfLife
                },
                InicioPublicacao = DateTime.Parse("Mar 25, 2019"),
                NumeroCapitulos = 98,
                ValorObra = 30,
                Sinopse = "O mestre espião de codinome <Crepúsculo> passou seus dias em missões secretas, tudo pelo " +
                "sonho de um mundo melhor. Mas um dia, ele recebe uma nova ordem particularmente difícil do comando. " +
                "Para sua missão, ele deverá formar uma família temporária e começar uma nova vida?! Um Espião/Ação/Comédia " +
                "sobre uma família única!"
            };
            var mensagemDeErroEsperada = "Obra não encontrada, o ID precisa ser informado!";

            var excecao = Assert.Throws<ValidationException>(() => _servicoObra.Editar(obraEditada));

            Assert.Equal(mensagemDeErroEsperada, excecao.Message);
        }

        //Método Remover
        [Fact]
        public void Remover_ComIdValido_DeveRemoverAObraCorreta()
        {
            var listaMock = InicializarDadosMockados();
            var obraASerRemovida = listaMock.FirstOrDefault();
            var idDaObra = obraASerRemovida.Id;
            var mensagemDeErro = $"O ID informado ({idDaObra}) é inválido. Obra não encontrada.";

            _servicoObra.Remover(idDaObra);
            var excecao = Assert.Throws<Exception>(() => _servicoObra.Remover(idDaObra));

            Assert.Equal(mensagemDeErro, excecao.Message);
        }

        [Fact]
        public void Remover_ComIdInvalido_DeveRetornarExcecao()
        {
            var idParaRemocao = 4000;
            var mensagemDeErro = $"O ID informado ({idParaRemocao}) é inválido. Obra não encontrada.";

            var excecao = Assert.Throws<Exception>(() => _servicoObra.Remover(idParaRemocao));

            Assert.Equal(mensagemDeErro, excecao.Message);
        }
    }
}