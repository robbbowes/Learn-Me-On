import { CourseLanguage } from '../language/courseLanguage';
import { Lesson } from '../lesson/lesson';

export interface Course {
    id: number;
    name: string;
    languageId: number;
    language: CourseLanguage;
    lessons: Lesson[];
}