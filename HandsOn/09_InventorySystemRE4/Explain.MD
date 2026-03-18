# O Desafio: Encapsulamento do seu Diagrama (Sistema Deal RE4)
**Resumo do Enunciado:** Olhando estritamente para o fluxo da sua Versão 4. Você tem o `CharacterManager` passando herança para o `Merchant` e `PlayerLeon`, e a `SuitcaseBase` gerenciando os itens. Vamos definir as trancas (+, -, #) exatamente para as variáveis e métodos que você escreveu nas suas caixas.

---

| GATILHOS (Esquerda) | FLUXO DE ACESSO DO SEU DIAGRAMA (Direita) |
| :--- | :--- |
| **O Cofre (Privado `-`)**<br>*(PlayerLeon e Suitcase)* | - A variável `money` do PlayerLeon deve ser **Privada (-)**. O Mercante não pode alterar o valor da carteira do Leon diretamente. O dinheiro é intocável de fora.<br>- A variável `spaceLimit` da SuitcaseBase deve ser **Privada (-)**. Nenhum script aleatório deve conseguir mudar o tamanho da maleta no meio do jogo. |
| **A Recepção (Público `+`)**<br>*(Merchant e Suitcase)* | - Os métodos `Talk()` e `Trade()` do Merchant devem ser **Públicos (+)**. O script do botão do jogador (quando aperta 'F' perto do NPC) precisa conseguir acionar a conversa e a loja.<br>- Os métodos `AddItem()` e `RemoveItem()` da SuitcaseBase são **Públicos (+)**. Quando o `Trade()` acontecer, a loja precisa ter permissão para colocar o item dentro da maleta do Leon. |
| **A Herança (Protegido `#`)**<br>*(CharacterManager)* | - No seu diagrama, `buyItems()` e `sellItems()` estão na classe pai (`CharacterManager`). Para evitar que uma porta ou cenário chame isso, você os define como **Protegidos (#)**. Assim, **apenas** as classes filhas (Leon e Merchant) herdam e têm permissão para usar esses comandos de comércio. |
| **Rotina Interna (Privado `-`)**<br>*(SuitcaseBase)* | - O método `organize()` da sua maleta deve ser **Privado (-)**. Quem organiza a maleta é a própria maleta nos bastidores quando o jogador aperta o botão. O Mercante não manda organizar a maleta do Leon. |

---

### Resumo (Rodapé)
> Aplicando no seu fluxo real: O dinheiro do Leon (money) e o tamanho da maleta (spaceLimit) ficam trancados como Privados (-) para proteger a economia e a mecânica do jogo. As ações que conectam os sistemas, como iniciar a negociação (Trade) ou entregar o item (AddItem), precisam estar abertas como Públicas (+). E o que for exclusivo da genética dos personagens (métodos de compra e venda herdados da base) fica blindado como Protegido (#).

### Fluxo
<br><br>


![RE4](InventorySystemRE4.jpg)
