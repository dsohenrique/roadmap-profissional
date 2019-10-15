import { add } from './main';

test('Adiciona 2 + 2 e retorna 4', ()=> {
    expect(add(2, 2)).toBe(4);
});