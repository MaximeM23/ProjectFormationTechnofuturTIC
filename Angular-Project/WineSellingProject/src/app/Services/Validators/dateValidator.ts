import { FormGroup, ValidationErrors, ValidatorFn } from '@angular/forms';

export const DateValidatorMaxLength: ValidatorFn = (control: FormGroup): ValidationErrors => {
  return  control.dirty && control.value.getDate() < new Date().getDate() ? { 'maxLength' : true} : { 'maxLength' : true } 
};

export const DateValidatorMinLength: ValidatorFn = (control: FormGroup): ValidationErrors => {
  return  control.dirty &&  control.value > 1900 ? { 'minLength' : true} : { 'minLength' : true } 
};

