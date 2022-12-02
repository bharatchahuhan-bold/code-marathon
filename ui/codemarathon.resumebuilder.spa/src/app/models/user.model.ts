export interface Address {
    addressLine1: string,
    addressLine2: string,
    city: string,
    state: string,
    country: string,
    zipCode: string
}

export interface Certification {
    id: number,
    company: string,
    endMonthYear: Date,
    name: string,
    startMonthYear: Date
}

export interface Education {
    id: number,
    degreeName: string,
    endMonthYear: Date,
    startMonthYear: Date,
    schoolName: string
}

export interface Organization {
    id: 0,
    endMonthYear: Date,
    description: string,
    startMonthYear: Date,
    name: string,
    occupation: string,
    position: string
}

export interface Project {
    id: 0,
    description: string,
    endMonthYear: Date,
    startMonthYear: Date,
    title: string
}

export interface User {
    firstName?: string,
    lastName?: string,
    profilePictureUrl?: string,
    address?: Address,
    birthDate?: Date,
    certifications?: Certification[],
    education?: Education[],
    organizations?: Organization[],
    projects?: Project[]
}