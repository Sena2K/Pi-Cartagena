using System;
using System.Collections.Generic;

namespace Cartagena
{
    class FilaPrioridade
    {
        private List<Entrada> jogadas = new List<Entrada>();

        public void Adicionar(Jogada jogada, int prioridade)
        {
            Entrada entrada = new Entrada(jogada, prioridade);

            // Verifica se a lista está vazia ou se a prioridade da entrada é maior que a última entrada na lista
            if (jogadas.Count == 0 || entrada.Chave > jogadas[jogadas.Count - 1].Chave)
            {
                jogadas.Add(entrada); // Adiciona a entrada no final da lista
            }
            else
            {
                int index = 0;
                // Encontra a posição correta para inserir a entrada com base em sua prioridade
                while (index < jogadas.Count && entrada.Chave <= jogadas[index].Chave)
                {
                    index++;
                }
                jogadas.Insert(index, entrada); // Insere a entrada na posição específica
            }
        }

        public Jogada Remover()
        {
            Jogada jogadaRemovida = null;
            if (jogadas.Count > 0)
            {
                int lastIndex = jogadas.Count - 1;
                jogadaRemovida = jogadas[lastIndex].Jogada; // Obtém a jogada da última entrada
                jogadas.RemoveAt(lastIndex); // Remove a última entrada da lista
            }
            return jogadaRemovida;
        }

        public override string ToString()
        {
            string result = "";
            foreach (Entrada entrada in jogadas)
            {
                result += entrada.Chave.ToString() + " "; // Concatena as chaves das entradas
            }
            return result;
        }
    }
}
