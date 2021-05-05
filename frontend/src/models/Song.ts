export type Song =  {
  id: string,
  interpret: string,
  title: string,
  subtitle?: string,
  mapper?: string,
  difficulty: {
    easy: boolean,
    normal: boolean,
    hard: boolean,
    expert: boolean,
    custom?: string[],
  },
};