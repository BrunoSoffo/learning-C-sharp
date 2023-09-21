int solution(int[] sequence) {
    return sequence.Max() - sequence.Min() - sequence.Length + 1;
}
int[] v1=new int[4]{6, 2, 3, 8};
solution(v1);