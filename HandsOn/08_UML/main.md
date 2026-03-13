## Fase 8: Do Diagrama ao Código - Associação, Encapsulamento e Enums

**Data:** 13.03.26 | **Matéria:** C# e Orientação a Objetos na Unity

---

| **CONCEITOS ARQUITETURAIS** | Na Prática |
| :--- | :--- |
| **A Regra de Ouro: Herança vs Associação** <br><br>Saber a diferença entre desenhar um encanamento de Herança ou de Associação é o que define se o jogo vai rodar ou quebrar. A regra é o teste lógico. | **Anatomia das Ligações:**<br><br>1. **Herança ("É UM") -->** O Inimigo *é um* Personagem base. <br>*(No C#: `public class IamEnemy : CharacterBase`)*<br><br>2. **Associação ("TEM UM") -->** O Herói *tem uma* Espada. <br>*(No C#: Criamos uma variável `public SwordHero minhaEspada;` dentro do Herói para criar a "ponte").* |
| **Encapsulamento (A Porta Trancada)**<br><br>**Lógica:** Segurança em primeiro lugar.<br><br>**O que é?**<br><br> Usei o encapsulamento para trancar as variáveis da nossa classe, impedindo que outros scripts alterem a vida ou o dano de forma acidental e causem bugs. | **A Mágica do `[SerializeField]`:**<br><br>Usei :<br>`[SerializeField] private float damageSword;`<br><br>O `private` tranca a porta no código. O `[SerializeField]` abre uma "janela de vidro" apenas visual para podermos editar o valor livremente lá no painel (Inspector) da Unity. |
| **Enums (O Menu Drop-down)**<br><br>**O Problema:** Escrever lógicas usando textos (strings) pode causar erros de digitação e confusão.<br><br>**A Solução:** Criamos uma lista de categorias (Enum). Isso gera um menu limpo e selecionável direto na Unity. | **Exemplo de Uso (Nível de Ameaça):**<br><br>`public enum TypesDifficulty`<br>`{ Easy, Normal, Hard, Dragon }`<br><br>O sistema não aceita outra coisa. Ou o inimigo é um desses 4, ou não é nada. Isso centraliza a regra de negócio. |
 | **O Perigo do `Update()`:**<br><br>Nunca coloque um `Debug.Log` dentro do método `Update()`, pois ele roda 60 vezes por segundo e trava a máquina. Para testes ou definições iniciais, use sempre o **`Start()`**, que roda apenas uma vez quando o objeto nasce. |
|


### A Planta Baixa (Diagrama de Classes Oficial)

![Diagrama Final](assets/Exerc08.png)