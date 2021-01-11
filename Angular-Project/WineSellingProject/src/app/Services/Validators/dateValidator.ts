import { FormGroup, ValidationErrors, ValidatorFn } from '@angular/forms';

export const DateValidatorMaxLength: ValidatorFn = (control: FormGroup): ValidationErrors => {
  return  control.dirty && control.value > new Date().getDate() ? { 'maxLength' : true} : { 'maxLength' : false } 
};

export const DateValidatorMinLength: ValidatorFn = (control: FormGroup): ValidationErrors => {
  return  control.dirty &&  control.value.getFullYear() < 1900 ? { 'minLength' : true} : { 'minLength' : false } 
};

