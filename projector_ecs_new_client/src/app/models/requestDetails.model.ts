export class RequestDetails {
  request!: RequestDetailsById;
  workTypes!: WorkType[];
}

export class RequestDetailsById {
  id!: number;
  authNumber!: number;
  authStatusId!: number;
  authDate!: string; // תאריך בקשה
  lastUpdate!: string; // תאריך עדכון
  planNumber!: string; // מספר תוכנית
  workDescription!: string; // מהות העבודה
  diggingLength!: string;
  diggingDepth!: string;
  diggingWidth!: string;
  comments!: string; // הערות
  idWorkType!: number;
  authRequestAuthority!: AuthRequestAuthority;
  approvers!:Approvers[];
}

export class WorkType {
  id!: number;
  name!: string;
}

export class AuthRequestAuthority {
  id!: number;
  authorityName!: string;
  tzHp!: string;
  phone!: string;
  address!: string;
  email!: string;
  idAuthorityType!: number;
}

export class Approvers {
  contactPersonName!:string;
  authorityName!:string;
  approvalStatus!:string;
  approvalDate!:string;
  comments!:string;
}