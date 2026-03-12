
## Fase 7: O Desafio do "Sistema de Inventário" (POO)

## Flowchart 

![Flowchart](DiagramaDeClasses.jpg)

### Contexto & Objetivo

* **Herança (Inheritance):** Estabelecer uma classe base (`ItemConsumivel`) que dita as propriedades globais, e uma classe derivada (`ItemPocao`) que herda essas regras.
* **Ação & Extensão:** Separar a ação básica de curar o jogador da ação específica de conceder um bônus de status (velocidade).
* **Polimorfismo:** Dominar o uso de `virtual` e `override` para permitir que diferentes itens no óculos VR reajam de forma única ao mesmo comando de "Usar".

### Decisões Arquiteturais

* **Separação de Responsabilidades (Separation of Concerns):** O escopo da classe restringe perfeitamente onde os métodos moram. A lógica do que define um item consumível genérico fica isolada da lógica que define uma poção específica. Isso garante que o método de cura possa ser reutilizado por outros itens (como lanches ou kits médicos) sem reescrever código.
* **Reaproveitamento de Estado (Base Call):** O fluxo garante que a lógica da classe pai seja verificada e executada *antes* da funcionalidade de alto nível da classe filha, prevenindo duplicação de lógica e mantendo o código limpo.

### Lógica de Negócio Central

O trecho abaixo destaca o método de uso sobrescrito e a correção do escopo. Sem a chamada obrigatória da classe base, o sistema perderia a funcionalidade original de cura, quebrando a cadeia de herança da categoria "Consumível".

> **Nota Arquitetural:** O fluxo garante que a lógica principal da classe pai (`base.Uses()`) seja invocada diretamente dentro do escopo do filho, assegurando que o jogador receba a cura padrão antes que o modificador exclusivo de velocidade seja aplicado.

---

### Resumo da Resolução

O objetivo principal é validar a hierarquia de herança para escalar o jogo sem gerar dívida técnica. Ao usar o polimorfismo e garantir que os métodos estejam encapsulados nas chaves `{ }` corretas, o sistema se mantém protegido, permitindo a criação de centenas de novos itens sem alterar o núcleo de inventário.

#### **Código de Implementação:**

```csharp
using UnityEngine;

namespace AutismyVR.Inventario
{
    public class ItemPocao : ItemConsumivel
    {
        public float velocidade;

        // Validação da Lógica de Negócio (Polimorfismo)
        public override void Uses()
        {
            // 1. Executa a ação da fundação (Curar Vida)
            base.Uses(); 

            // 2. Executa a ação autorizada exclusiva desta classe
            Debug.Log("Status Autorizado: Bônus de velocidade aplicado. (" + velocidade + ")");
        }
    }
}

```

---

**Próximo Passo:**
Gostaria que eu adaptasse também o código da classe pai (`ItemConsumivel`) para este mesmo formato de documentação, para que você tenha a arquitetura inteira padronizada no seu caderno?