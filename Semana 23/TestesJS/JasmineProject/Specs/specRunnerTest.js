let year = '2019';

describe('Get year dates', () => {
    it("should be a number", () => {
        year = parseInt(year);
        expect(year).toBe(2019);
    });

    it("should be a 2020", () => {
        year = 2020;
        expect(year).toBe(2020);
    });

    //Para gerar erro no Assert basta descomentar o código abaixo
    
    //it("should be a 2020", () => {
    //    year = parseInt(year);
    //    expect(year).toBe(2020);
    //});
});