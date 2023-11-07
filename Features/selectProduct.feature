#language: pt
Funcionalidade: Selecionar Produto na Loja
    @Loja
    Cenario: Selecao de Produto com Sucesso
        Dado que acesso a página inicial do site
        Quando preencho o usuário como "standard_user"
        E a senha "sauce_secret" e clico no botao Login
        Entao exibe "Products" no titulo da secao
        Quando adiciono o produto "Sauce Labs Backpack" ao carrinho
        E clico no icone do carrinho de compras
        Entao exibe a pagina do carrinho com a quantidade "1"
        E nome do produto "Sauce Labs Backpack"
        E o preco como "$29.99"

    Esquema do Cenario: Selecao de Produto com Sucesso
        Dado que acesso a página inicial do site
        Quando preencho o <usuario>
        E a senha <senha> e clico no botao Login
        Entao exibe <tituloSecao> no titulo da secao
        Quando adiciono o produto <tituloSecao > ao carrinho
        E clico no icone do carrinho de compras
        Entao exibe a pagina do carrinho com a <quantidade> "1"
        E nome do produto <produto>
        E o <preco> como "$29.99"

    Exemplos:
    |usuario         |senha              |tituloSecao|produto               |quantidade     | preco   |
    |"standard_user" | "sauce_secret"    | "Products"|"Sauce Labs Backpack" |"1"        | "$29.99"|
    |"visual_user"   | "sauce_secret"    | "Products"|"Sauce Labs light"    |"1"        | "$9.99" |

