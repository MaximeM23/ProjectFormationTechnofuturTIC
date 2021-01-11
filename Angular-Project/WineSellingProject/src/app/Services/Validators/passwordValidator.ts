import { FormGroup, ValidationErrors, ValidatorFn } from '@angular/forms';

export const PasswordValidatorMaxLength: ValidatorFn = (control: FormGroup): ValidationErrors => {
  return  control.dirty && control.value.length > 50 ? { 'maxLength' : true} : { 'maxLength' : false } 
};

export const PasswordValidatorMinLength: ValidatorFn = (control: FormGroup): ValidationErrors => {
  return  control.dirty && control.value.length < 3 ? { 'minLength' : true} : { 'minLength' : false } 
};

