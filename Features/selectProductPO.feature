#language: pt
Funcionalidade: Selecionar Produto na Loja
    @PO
    Esquema do Cenario: Selecao de Produto com Sucesso PO
        Dado que acesso a página inicial do site PO
        Quando preencho o <usuario> PO
        E a senha <senha> e clico no botao Login PO
        Entao exibe <tituloSecao> no titulo da secao PO
        Quando adiciono o produto <tituloSecao > ao carrinho PO
        E clico no icone do carrinho de compras PO
        Entao exibe a pagina do carrinho com a <quantidade> "1" PO
        E nome do produto <produto> PO
        E o <preco> como "$29.99" PO

    Exemplos:
    |usuario         |senha              |tituloSecao|produto               |quantidade     | preco   |
    |"standard_user" | "sauce_secret"    | "Products"|"Sauce Labs Backpack" |"1"        | "$29.99"|
    |"visual_user"   | "sauce_secret"    | "Products"|"Sauce Labs light"    |"1"        | "$9.99" |

