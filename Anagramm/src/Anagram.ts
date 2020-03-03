export default class Anagramm {

    /* Ein Anagramm ist ein Wort, das durch die Umstellung der Buchstaben eines anderem Wortes gebildet werden kann.
     * Bsp: AMPEl und PALME, MEHL und HELM
     */
    istAnagramm(wortEins: string, wortZwei: string) : boolean{
        let result: boolean;
        if(wortEins.length === wortZwei.length){
            let arrWortEins = wortEins.toLowerCase().split('');
            let arrWortZwei = wortZwei.toLowerCase().split('');

            let sortWortEins = arrWortEins.sort().toString();
            let sortWortZwei = arrWortZwei.sort().toString();

            result = sortWortEins === sortWortZwei;
        }
        else{
            result = false;
        }
        return result;
    }
}