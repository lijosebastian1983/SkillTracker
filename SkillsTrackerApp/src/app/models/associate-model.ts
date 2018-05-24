import { AssociateSkillsModel } from './associate-skills-model';
export class AssociateModel {
    AssociateDetailsId: number;
    AssociateId: string;
    Name: string;
    Email: string;
    Mobile: string;
    Pic: string;
    Status: string;
    Level: string;
    Strength: string;
    Weekness: string;
    OtherSkills: string;
    AssociateSkills:AssociateSkillsModel[];
}
