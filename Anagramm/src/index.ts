import Anagram from "./Anagram";
const anagram = new Anagram();

const pruefe = (wort1: string, wort2: string) => {
    const isAnagram = anagram.istAnagramm(wort1, wort2);
    console.log(`${wort1} und ${wort2} bilden ${isAnagram ? "ein" : "kein"} Anagramm.`);
}

pruefe("Helm", "Mehl");
pruefe("Pferd", "Herd");
pruefe("Ampel", "Palme");
