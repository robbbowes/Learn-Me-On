import { Sentence } from '../sentence/sentence';

export interface Lesson {
    number: number;
    language: number;
    courseId: number;
    audio: string;
    sentences: Sentence[];
    lessonStatus: any;
}