
# Summary

- [How This Work ?](#section-1)
- [What's Namespace and Class? ](#section-2)
#



# Module C# intermediate 

## **How this work?**

## **What's Namespace And Class?**


![image1](assets/middle.png)
![image1](assets/last.png)
![image1](assets/first.png)



# Notas Cornell: Arquitetura de Comunicação (Unity)
Data: 23/03/2026 | Matéria: C# Avançado - Métodos vs Eventos

---

| TÓPICOS / GATILHOS (Cues) | ANOTAÇÕES PRÁTICAS (Notes) |
| :--- | :--- |
| **Método (Method)** | É uma **ordem direta** (Comunicação 1 para 1).<br>• *Como funciona:* O Script A manda o Script B fazer algo.<br>• *Analogia:* Uma ligação telefônica privada. Você precisa saber o número exato da pessoa.<br>• *Exemplo:* `telaUI.LigarTela();` |
| **Acoplamento Forte**<br>*(O Perigo dos Métodos)* | É quando os "tijolos estão colados".<br>• Se o Script B for deletado, o Script A quebra e o jogo trava (Erro: `NullReferenceException`), porque o A dependia do B para funcionar. |
| **Evento (Event / Action)** | É um **aviso geral** (Comunicação 1 para Muitos).<br>• *Como funciona:* O Script A apenas "grita" que algo aconteceu. Ele não faz ideia de quem está escutando. Quem se interessar, reage.<br>• *Analogia:* O Alarme de Incêndio da fábrica. |
| **Acoplamento Fraco**<br>*(A Vantagem dos Eventos)* | É a arquitetura "Lego". Módulos independentes.<br>• Se a UI for deletada, o jogo **não quebra**. O Mercante simplesmente grita para o vazio, e a vida segue normalmente. |
| **Quando usar cada um?** | • **Métodos:** Para a lógica interna do próprio script (ex: o Leon calculando se tem dinheiro).<br>• **Eventos:** Para sistemas diferentes conversarem (ex: O Mercante avisando a UI para ligar, o Áudio para tocar e o Leon para travar o movimento). |

---

### Resumo (Summary)
> A diferença entre um programador Júnior e um Sênior está no controle do **Acoplamento**. Usar *Métodos* para ligar sistemas diferentes cria um código frágil ("espaguete"), onde deletar um objeto quebra o jogo inteiro. Usar *Eventos* (como `UnityEvents` ou `Action` em C#) cria uma arquitetura modular, permitindo que a Loja, a UI, o Áudio e o Jogador funcionem de forma totalmente independente. O Mercante apenas anuncia a abertura da loja; os outros sistemas escutam e reagem por conta própria.
