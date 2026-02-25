# Controle de Acesso (State Machine)

Módulo de segurança para gerenciamento de permissões de usuários (níveis 0 a 3) baseado em inputs de teclado.

## Decisões Técnicas
* **Single Responsibility Principle (SRP):** A leitura de input (`Update`) foi isolada da manipulação de dados (`UserUpgrade`) e da interface de resposta (`CheckAcess`).
* **Operador de Módulo (%):** O ciclo de progressão de níveis foi implementado com matemática pura, evitando blocos condicionais extensos para resetar o estado.



## Fluxograma

![alt text](<Phase 3 The Access Level SystemSwitch Case Logic-1.png>)

## Lógica Central

Abaixo está o motor de progressão de nível. A utilização de `(valor + 1) % limite` garante que o nível retorne a 0 após atingir o limite máximo (3).

```csharp
public void UserUpgrade()
{
    acessControl = (acessControl + 1) % 4; 
}