import { Translation } from '../translation/translation';

export interface Sentence {
    id: number;
    number: number;
    sentenceLanguage: number;
    sentenceText: string;
    translations: Translation[];
    sentenceAudio: string;
    recordedAudio: string;
}